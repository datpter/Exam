// See https://aka.ms/new-console-template for more information
using Exam;
using Exam.Data;
using Exam.Models;

DataContext context = new DataContext();
MembershipController membershipController = new MembershipController(context);
Console.Write("Enter membership's name: ");
string name = Console.ReadLine();
Membership membership = new Membership {  Name = name };
membershipController.Add(membership);