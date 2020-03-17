using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Lab1
    {
 
        //Declare a Class
        public class BankAccount
        {
            private int id;
            private decimal balance;
            public int Id;
            public decimal Balance;

            public BankAccount(int id, decimal balance)
            {
                this.id = id;
                this.balance = balance;
            }

            public BankAccount()
            {
            }

            public void Deposit(int depositAmount)
            {
                balance = balance + depositAmount;
            }
            public void WithDraw(int withdrawAmount)
            {
                balance = balance - withdrawAmount;
            }
            public int ID
            {
                get { return this.id; }
                set { this.id = value; }
            }

            public decimal alance
            {
                get { return this.balance; }
                set { this.balance = value; }
            }
            // ???
            internal void Withdraw(decimal v, decimal amount)
            {
                throw new NotImplementedException();
            }

            internal void Withdraw(decimal amount)
            {
                throw new NotImplementedException();
            }

            internal void Deposit(double amount)
            {
                throw new NotImplementedException();
            }
        }
        public class Person
        {
            private string name;
            private int age;
            private List<BankAccount> accounts;

            public Person(string name, int age) : this(name, age, new List<BankAccount>())
            {
            }

            public Person(string name, int age, List<BankAccount> accounts)
            {
                this.name = name;
                this.age = age;
                this.accounts = accounts;
            }

            public decimal GetBalance()
            {
                return this.accounts.Select(a => a.Balance).Sum();
            }
        }

        public class StartUp
        {
            public static void Start()
            {
                var accounts = new Dictionary<int, BankAccount>();
                var input = Console.ReadLine();

                while (input != "End")
                {
                    var command = input.Split();

                    switch (command[0])
                    {
                        case "Create":
                            CreateAccount(int.Parse(command[1]), accounts);
                            break;
                        case "Deposit":
                            Deposit(int.Parse(command[1]), decimal.Parse(command[2]), accounts);
                            break;
                        case "Withdraw":
                            Withdraw(int.Parse(command[1]), decimal.Parse(command[2]), accounts);
                            break;
                        case "Print":
                            Print(int.Parse(command[1]), accounts);
                            break;
                        default:
                            break;
                    }

                    input = Console.ReadLine();
                }
            }
            // ???
            private static void Deposit(int v1, decimal v2, Dictionary<int, BankAccount> accounts)
            {
                throw new NotImplementedException();
            }
            // ???
            private static void Print(int id, Dictionary<int, BankAccount> accounts)
            {
                if (!accounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                    return;
                }

                Console.WriteLine(accounts[id].ToString());
            }

            private static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> accounts)
            {
                if (!accounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                    return;
                }

                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                    return;
                }

                accounts[id].Withdraw(amount);
            }

            private static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
            {
                if (!accounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                    return;
                }

                accounts[id].Deposit(amount);
            }

            private static void CreateAccount(int id, Dictionary<int, BankAccount> accounts)
            {
                if (accounts.ContainsKey(id))
                {
                    Console.WriteLine("Account already exists");
                    return;
                }

                accounts[id] = new BankAccount(id);
            }
        }

        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;
            acc.Deposit(15);
            acc.WithDraw(10);
            Console.WriteLine($"Account {acc.Id}, balance { acc.Balance}");

            Console.WriteLine(acc);
        }

    }
}
