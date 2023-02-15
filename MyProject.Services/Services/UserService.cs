using AutoMapper;
using AutoMapper.Internal;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Enums;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO userDTO)
        {
            var user = await _userRepository.GetByTzAsync(userDTO.Tz);
            if (user != null)
            {
                user.FirstName = userDTO.FirstName;
                user.LastName = userDTO.LastName;
                user.BirthDate = userDTO.BirthDate;
                user.Gender = userDTO.Gender;
                user.HMO = _mapper.Map<HMOEnum>(userDTO.HMO);
                if (!string.IsNullOrEmpty(userDTO.Parent_1_tz))
                    if (string.IsNullOrEmpty(user.Parent_1_tz))
                        user.Parent_1_tz = userDTO.Parent_1_tz;
                    else if (user.Parent_1_tz != userDTO.Parent_1_tz && string.IsNullOrEmpty(user.Parent_2_tz))
                        user.Parent_2_tz = userDTO.Parent_1_tz;
               return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(user));
            }
            else
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(userDTO.FirstName, userDTO.LastName, userDTO.Tz, userDTO.BirthDate, userDTO.Gender, _mapper.Map<HMOEnum>(userDTO.HMO), userDTO.Parent_1_tz));
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> GetByTzAsync(string tz)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByTzAsync(tz));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO userDTO)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(userDTO)));
        }
    }
}
