﻿namespace Imttech.Test1.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public AccountType Type { get; set; }
    }

    public enum AccountType
    {
        Asset,
        Expense,
        Revenue,
    }
}
