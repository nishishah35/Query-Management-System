
# 🎫 Query Management System

A web application to manage and resolve customer queries, built with ASP.NET Core MVC and PostgreSQL.

---

## 🛠️ Tech Stack

- **Framework:** ASP.NET Core 8 (MVC)
- **Language:** C#
- **Database:** PostgreSQL
- **Auth:** Session-based Authentication

---

## 👥 User Roles

- **Admin** — View all queries, manage users, access analytics
- **Employee** — Resolve queries, track personal metrics
- **User** — Submit and manage their own queries

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

1. Fork the repo
2. Create a branch: `git checkout -b feature/YourFeature`
3. Commit: `git commit -m "Add YourFeature"`
4. Push: `git push origin feature/YourFeature`
5. Open a Pull Request

---

<div align="center">Made with ❤️ using ASP.NET Core & PostgreSQL</div>
