using System;
using System.Collections.Generic;

namespace Domain
{
	public class BankAccount
	{
		public AccountType AccountType { get; private set; }
		public int Id { get; private set; }

		public BankAccount(int id, AccountType accountType, decimal balance)
		{
			AccountType = accountType;
			Id = id;
			Balance = balance;
		}

		public void Deposit(Currency currency)
		{
			decimal balance = currency.Amount; // TODO: conversion strategy
			Balance += balance;
			transactions.Add(new Transaction(DateTime.Now, balance, false));
		}

		private readonly List<Transaction> transactions = new List<Transaction>();

		public IEnumerable<Transaction> Transactions
		{
			get
			{
				return transactions;
			}
		}

		public decimal Balance { get; private set; }
	}

	public enum AccountType
	{
		Unknown,
		Savings,
		Cheqing,
		Rrsp,
		Tfsa
	};
}