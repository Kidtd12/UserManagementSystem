 User Management System (ASP.NET Core Razor Pages)

 
Project Overview

The User Management System (UMS) is a simple web application built with ASP.NET Core Razor Pages and SQL Server. It allows users to register, login, and manage roles. The system supports three types of users:

Admin – Full access to manage users and roles.

Employee – Can manage tasks and customer information.

Customer – Can register and view personal data.

This project is beginner-friendly and demonstrates role-based access control, database integration, and Razor Pages forms.

Technologies Used

ASP.NET Core 8 – Web framework.

Razor Pages – Server-side web pages with C# code-behind.

Entity Framework Core – ORM for database operations.

SQL Server (LocalDB) – Database for user data.

Bootstrap 5 – Simple styling and responsive design.

Features

User Registration

Users can sign up with User Name, Email, Password, and Role.

Role selection dropdown: Admin, Employee, Customer.

Password validation and confirmation.

User Login

Users can log in with Email and Password.

Role-based redirection (Admin, Employee, Customer dashboards).

Database

UserInfo database with table UserData.

Columns: UserID, UserName, Email, Password, Role.

Role Management

Admin can view all users and their roles.

Employees and Customers have restricted access.
