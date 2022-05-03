﻿using Ordina.StichtingNuTwente.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.StichtingNuTwente.Business.Interfaces
{
    public interface IUserService
    {
        public UserDetails? GetUserByAADId(string id);
        public UserDetails? UpdateUser(UserDetails user, string aadId);
        public UserDetails? UpdateUserFromProfileEdit(UserDetails user, string aadId);
        public ICollection<UserDetails> GetUsersByRole(string role);
        public ICollection<UserDetails> GetAllUsers();
        public ICollection<Reactie> GetMyReacties(string aadId);
        public void checkIfUserExists(ClaimsPrincipal user);
        public void Save(UserDetails user);
        public UserDetails? getUserFromClaimsPrincipal(ClaimsPrincipal user);
        public UserDetails? GetUserById(int id);
        public UserDetails? UpdateUser(UserDetails user, int id);
        public ICollection<UserDetails> GetAllDropdownUsers();
    }
}
