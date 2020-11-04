﻿namespace TenmoServer.Models
{
    /// <summary>
    /// Model to return upon successful login
    /// </summary>
    public class ReturnUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        //public string Role { get; set; }
        public string Token { get; set; }

        public int AccountId { get; set; }

        public decimal AccountBalance { get; set; }

    }
}
