# 🎫 Query Management System

A web application to manage and resolve customer queries, built with ASP.NET Core MVC and PostgreSQL.

---

## 🛠️ Tech Stack

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core_8-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=flat-square&logo=postgresql&logoColor=white)
![MVC](https://img.shields.io/badge/MVC_Pattern-FF6C37?style=flat-square&logo=visualstudio&logoColor=white)
![Session Auth](https://img.shields.io/badge/Session_Auth-F59E0B?style=flat-square&logoColor=white)

---

## 👥 User Roles

![Admin](https://img.shields.io/badge/🛡️_Admin-4F46E5?style=flat-square&logoColor=white) View all queries, manage users, access analytics

![Employee](https://img.shields.io/badge/👷_Employee-0891B2?style=flat-square&logoColor=white) Resolve queries, track personal metrics

![User](https://img.shields.io/badge/🧑‍💼_User-059669?style=flat-square&logoColor=white) Submit and manage their own queries

---

## 🚀 Getting Started

**1. Clone the repo**
```bash
git clone https://github.com/yourusername/Query-Management-System.git
cd Query-Management-System
```

**2. Set up the database**

Update the connection string in `appsettings.json`:
```json
"pgconn": "Host=localhost;Port=5432;Database=QueryManagementDB;Username=...;Password=..."
```

**3. Run the app**
```bash
cd MVC
dotnet restore
dotnet run
```

**4. Open in browser**
```
https://localhost:5001
```

---

## 📁 Project Structure

```
Query_Management_System/
├── MVC/
│   ├── Controllers/      ← Admin, Employee, Query, User, Account
│   ├── Views/            ← Razor pages per role
│   └── Program.cs        ← App entry & DI config
└── Repository/
    ├── Interfaces/
    ├── Implementations/
    └── Models/
```

---

## 🤝 Contributing

![Step 1](https://img.shields.io/badge/1-Fork_the_repo-6366F1?style=flat-square)
![Step 2](https://img.shields.io/badge/2-Create_a_branch-0EA5E9?style=flat-square)
![Step 3](https://img.shields.io/badge/3-Commit_changes-10B981?style=flat-square)
![Step 4](https://img.shields.io/badge/4-Push_&_PR-F59E0B?style=flat-square)

```bash
git checkout -b feature/YourFeature
git commit -m "Add YourFeature"
git push origin feature/YourFeature
```

---

<div align="center">

![Made with love](https://img.shields.io/badge/Made_with_❤️-ASP.NET_Core_&_PostgreSQL-EC4899?style=flat-square)

</div>
