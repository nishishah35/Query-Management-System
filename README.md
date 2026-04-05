<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<title>Query Management System — README</title>
<link href="https://fonts.googleapis.com/css2?family=Syne:wght@400;700;800&family=DM+Sans:wght@300;400;500&display=swap" rel="stylesheet"/>
<style>
  *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }
  body {
    font-family: 'DM Sans', sans-serif;
    background: #0b0f1a;
    color: #e2e8f0;
    min-height: 100vh;
    padding: 2rem 1rem 4rem;
  }
  .readme {
    max-width: 820px;
    margin: 0 auto;
  }

  /* HERO */
  .hero {
    background: linear-gradient(135deg, #0f0c29, #302b63, #24243e);
    border-radius: 24px;
    padding: 3.5rem 2rem 3rem;
    text-align: center;
    position: relative;
    overflow: hidden;
    margin-bottom: 2.5rem;
    border: 1px solid rgba(129,140,248,0.2);
  }
  .hero::before {
    content: '';
    position: absolute;
    top: -80px; right: -80px;
    width: 280px; height: 280px;
    background: radial-gradient(circle, rgba(99,102,241,0.35), transparent 70%);
    border-radius: 50%;
  }
  .hero::after {
    content: '';
    position: absolute;
    bottom: -60px; left: -40px;
    width: 220px; height: 220px;
    background: radial-gradient(circle, rgba(16,185,129,0.25), transparent 70%);
    border-radius: 50%;
  }
  .hero-icon { font-size: 56px; display: block; margin-bottom: 1rem; position: relative; z-index: 1; }
  .hero h1 {
    font-family: 'Syne', sans-serif;
    font-size: 2.6rem;
    font-weight: 800;
    color: #fff;
    letter-spacing: -0.5px;
    margin-bottom: 0.75rem;
    position: relative; z-index: 1;
  }
  .hero p {
    color: rgba(255,255,255,0.6);
    font-size: 1rem;
    font-weight: 300;
    max-width: 500px;
    margin: 0 auto 1.8rem;
    line-height: 1.7;
    position: relative; z-index: 1;
  }
  .badges {
    display: flex; flex-wrap: wrap; gap: 8px; justify-content: center;
    position: relative; z-index: 1;
  }
  .badge {
    padding: 5px 16px;
    border-radius: 999px;
    font-size: 12px;
    font-weight: 500;
    letter-spacing: 0.3px;
    border: 1px solid rgba(255,255,255,0.18);
    color: #fff;
  }
  .b-purple { background: rgba(99,102,241,0.4); }
  .b-blue   { background: rgba(59,130,246,0.35); }
  .b-teal   { background: rgba(16,185,129,0.35); }
  .b-amber  { background: rgba(245,158,11,0.35); }

  /* SECTION TITLE */
  .section-title {
    font-family: 'Syne', sans-serif;
    font-size: 1.2rem;
    font-weight: 700;
    color: #f1f5f9;
    margin: 2.8rem 0 1.2rem;
    display: flex;
    align-items: center;
    gap: 10px;
  }
  .dot {
    width: 9px; height: 9px;
    border-radius: 50%;
    display: inline-block;
    flex-shrink: 0;
  }
  .dot-purple { background: #818cf8; }
  .dot-teal   { background: #34d399; }
  .dot-blue   { background: #60a5fa; }
  .dot-pink   { background: #f472b6; }
  .dot-amber  { background: #fbbf24; }

  /* FEATURE CARDS */
  .cards-grid {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(185px, 1fr));
    gap: 12px;
  }
  .card {
    border-radius: 16px;
    padding: 1.2rem 1.3rem;
    border: 1px solid rgba(255,255,255,0.07);
  }
  .card-purple { background: linear-gradient(135deg, #312e81, #3730a3); }
  .card-teal   { background: linear-gradient(135deg, #064e3b, #065f46); }
  .card-blue   { background: linear-gradient(135deg, #1e3a5f, #1e40af); }
  .card-pink   { background: linear-gradient(135deg, #831843, #9d174d); }
  .card-amber  { background: linear-gradient(135deg, #78350f, #92400e); }
  .card-indigo { background: linear-gradient(135deg, #312e81, #4338ca); }
  .card-green  { background: linear-gradient(135deg, #14532d, #166534); }
  .card-rose   { background: linear-gradient(135deg, #881337, #9f1239); }
  .card-icon { font-size: 24px; margin-bottom: 10px; display: block; }
  .card h3 {
    font-family: 'Syne', sans-serif;
    font-size: 0.9rem;
    font-weight: 700;
    color: #fff;
    margin-bottom: 5px;
  }
  .card p { font-size: 0.78rem; color: rgba(255,255,255,0.58); line-height: 1.55; }

  /* ROLES */
  .roles-grid { display: grid; grid-template-columns: repeat(3, 1fr); gap: 12px; }
  .role-card { border-radius: 18px; padding: 1.6rem 1.2rem; text-align: center; }
  .role-admin { background: linear-gradient(160deg, #1e1b4b, #312e81); border: 1px solid rgba(129,140,248,0.25); }
  .role-emp   { background: linear-gradient(160deg, #083344, #0e4863); border: 1px solid rgba(56,189,248,0.25); }
  .role-user  { background: linear-gradient(160deg, #1a2e05, #14532d); border: 1px solid rgba(74,222,128,0.25); }
  .role-emoji { font-size: 30px; display: block; margin-bottom: 10px; }
  .role-title { font-family: 'Syne', sans-serif; font-size: 1rem; font-weight: 700; color: #fff; margin-bottom: 10px; }
  .role-list  { list-style: none; padding: 0; }
  .role-list li { font-size: 0.76rem; color: rgba(255,255,255,0.58); padding: 3px 0; }

  /* TECH STACK */
  .tech-grid { display: grid; grid-template-columns: repeat(auto-fill, minmax(155px, 1fr)); gap: 10px; }
  .tech-pill {
    display: flex; align-items: center; gap: 10px;
    padding: 11px 14px;
    border-radius: 12px;
    background: #131929;
    border: 1px solid rgba(255,255,255,0.08);
  }
  .tech-color { width: 10px; height: 10px; border-radius: 50%; flex-shrink: 0; }
  .tech-label { font-size: 0.83rem; font-weight: 500; color: #f1f5f9; }
  .tech-sub   { font-size: 0.7rem; color: #64748b; }

  /* STEPS */
  .steps { display: flex; flex-direction: column; gap: 12px; }
  .step {
    display: flex; gap: 14px; align-items: flex-start;
    padding: 1.1rem 1.3rem;
    border-radius: 14px;
    background: #131929;
    border: 1px solid rgba(255,255,255,0.07);
  }
  .step-num {
    width: 34px; height: 34px; border-radius: 50%;
    display: flex; align-items: center; justify-content: center;
    font-family: 'Syne', sans-serif; font-size: 0.8rem; font-weight: 700;
    flex-shrink: 0; color: #fff;
  }
  .sn-1 { background: #6366f1; }
  .sn-2 { background: #0ea5e9; }
  .sn-3 { background: #10b981; }
  .sn-4 { background: #f59e0b; }
  .step-content h4 { font-size: 0.92rem; font-weight: 600; margin-bottom: 5px; color: #f1f5f9; }
  .step-content p  { font-size: 0.8rem; color: #94a3b8; line-height: 1.5; }
  .code-block {
    background: #070d1a;
    color: #a5f3fc;
    border-radius: 10px;
    padding: 10px 14px;
    font-family: 'Courier New', monospace;
    font-size: 0.76rem;
    margin-top: 8px;
    line-height: 1.8;
    border: 1px solid rgba(255,255,255,0.07);
  }
  .cm { color: #475569; }
  .ck { color: #f472b6; }
  .cv { color: #86efac; }

  /* ENDPOINTS */
  .ep-group { margin-bottom: 1.5rem; }
  .ep-label {
    display: inline-flex; align-items: center; gap: 6px;
    font-size: 0.78rem; font-weight: 600;
    padding: 4px 14px; border-radius: 999px;
    margin-bottom: 8px; color: #fff;
  }
  .ep-auth  { background: #dc2626; }
  .ep-admin { background: #4f46e5; }
  .ep-emp   { background: #0891b2; }
  .ep-query { background: #059669; }
  .ep-row {
    display: grid; grid-template-columns: 60px 1fr auto;
    gap: 8px; align-items: center;
    padding: 8px 12px; border-radius: 9px;
    margin-bottom: 4px;
    background: #131929;
    border: 1px solid rgba(255,255,255,0.06);
  }
  .method {
    font-size: 0.7rem; font-weight: 700;
    padding: 2px 8px; border-radius: 4px; text-align: center;
  }
  .m-get  { background: rgba(5,150,105,0.2); color: #34d399; }
  .m-post { background: rgba(245,158,11,0.2); color: #fbbf24; }
  .ep-path { font-family: 'Courier New', monospace; font-size: 0.78rem; color: #c7d2fe; }
  .ep-desc { font-size: 0.72rem; color: #64748b; text-align: right; }

  /* PROJECT STRUCTURE */
  .tree {
    background: #070d1a;
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 14px;
    padding: 1.2rem 1.5rem;
    font-family: 'Courier New', monospace;
    font-size: 0.78rem;
    line-height: 2;
    color: #94a3b8;
  }
  .tree .folder { color: #60a5fa; font-weight: 600; }
  .tree .file   { color: #a5f3fc; }
  .tree .comment{ color: #475569; }

  /* FOOTER */
  .footer {
    text-align: center;
    margin-top: 3rem;
    padding: 2.5rem 2rem;
    border-radius: 20px;
    background: linear-gradient(135deg, #0f172a, #1e1b4b);
    border: 1px solid rgba(129,140,248,0.2);
  }
  .footer p { color: rgba(255,255,255,0.45); font-size: 0.85rem; line-height: 2; }
  .footer strong { color: #a5b4fc; }
  .star-btn {
    display: inline-block;
    margin-top: 1.2rem;
    padding: 10px 24px;
    border-radius: 999px;
    background: linear-gradient(90deg, #6366f1, #8b5cf6);
    color: #fff;
    font-size: 0.85rem;
    font-weight: 600;
    text-decoration: none;
    letter-spacing: 0.3px;
  }

  @media (max-width: 600px) {
    .roles-grid { grid-template-columns: 1fr; }
    .hero h1 { font-size: 1.8rem; }
  }
</style>
</head>
<body>
<div class="readme">

  <!-- HERO -->
  <div class="hero">
    <span class="hero-icon">🎫</span>
    <h1>Query Management System</h1>
    <p>A full-stack ASP.NET Core MVC web application to manage, track, and resolve customer queries with role-based access control.</p>
    <div class="badges">
      <span class="badge b-purple">ASP.NET Core 8</span>
      <span class="badge b-blue">C#</span>
      <span class="badge b-teal">PostgreSQL</span>
      <span class="badge b-amber">MVC Pattern</span>
    </div>
  </div>

  <!-- FEATURES -->
  <div class="section-title"><span class="dot dot-purple"></span>Features</div>
  <div class="cards-grid">
    <div class="card card-purple"><span class="card-icon">🔐</span><h3>Role-Based Auth</h3><p>Separate dashboards for Admin, Employee & User roles</p></div>
    <div class="card card-teal"><span class="card-icon">📝</span><h3>Query CRUD</h3><p>Create, view, update and delete support queries</p></div>
    <div class="card card-blue"><span class="card-icon">✅</span><h3>Resolution Flow</h3><p>Employees resolve queries with comments & status</p></div>
    <div class="card card-pink"><span class="card-icon">📊</span><h3>Admin Dashboard</h3><p>Full analytics — all queries, users & metrics</p></div>
    <div class="card card-amber"><span class="card-icon">👷</span><h3>Employee Metrics</h3><p>Personal stats: resolved, active & urgent alerts</p></div>
    <div class="card card-green"><span class="card-icon">👤</span><h3>Self Registration</h3><p>Company users can self-register and manage queries</p></div>
    <div class="card card-indigo"><span class="card-icon">🔒</span><h3>Session Auth</h3><p>Secure session-based auth with 30-min timeout</p></div>
    <div class="card card-rose"><span class="card-icon">🚪</span><h3>Safe Logout</h3><p>Session clearing + cookie deletion across all roles</p></div>
  </div>

  <!-- ROLES -->
  <div class="section-title"><span class="dot dot-blue"></span>User Roles</div>
  <div class="roles-grid">
    <div class="role-card role-admin">
      <span class="role-emoji">🛡️</span>
      <div class="role-title">Admin</div>
      <ul class="role-list">
        <li>View all queries</li><li>Manage all users</li>
        <li>Delete any query</li><li>Full analytics</li>
      </ul>
    </div>
    <div class="role-card role-emp">
      <span class="role-emoji">👷</span>
      <div class="role-title">Employee</div>
      <ul class="role-list">
        <li>View open queries</li><li>Resolve with comment</li>
        <li>Personal metrics</li><li>Urgent alerts</li>
      </ul>
    </div>
    <div class="role-card role-user">
      <span class="role-emoji">🧑‍💼</span>
      <div class="role-title">User</div>
      <ul class="role-list">
        <li>Self registration</li><li>Submit queries</li>
        <li>Track own history</li><li>Edit or delete</li>
      </ul>
    </div>
  </div>

  <!-- TECH STACK -->
  <div class="section-title"><span class="dot dot-teal"></span>Tech Stack</div>
  <div class="tech-grid">
    <div class="tech-pill"><div class="tech-color" style="background:#818cf8"></div><div><div class="tech-label">ASP.NET Core</div><div class="tech-sub">Framework</div></div></div>
    <div class="tech-pill"><div class="tech-color" style="background:#34d399"></div><div><div class="tech-label">C#</div><div class="tech-sub">Language</div></div></div>
    <div class="tech-pill"><div class="tech-color" style="background:#60a5fa"></div><div><div class="tech-label">PostgreSQL</div><div class="tech-sub">Database</div></div></div>
    <div class="tech-pill"><div class="tech-color" style="background:#f472b6"></div><div><div class="tech-label">Npgsql</div><div class="tech-sub">DB Driver</div></div></div>
    <div class="tech-pill"><div class="tech-color" style="background:#fbbf24"></div><div><div class="tech-label">Razor Views</div><div class="tech-sub">Frontend (.cshtml)</div></div></div>
    <div class="tech-pill"><div class="tech-color" style="background:#fb923c"></div><div><div class="tech-label">Repository</div><div class="tech-sub">Pattern + DI</div></div></div>
  </div>

  <!-- GETTING STARTED -->
  <div class="section-title"><span class="dot dot-amber"></span>Getting Started</div>
  <div class="steps">
    <div class="step">
      <div class="step-num sn-1">1</div>
      <div class="step-content">
        <h4>Clone the Repository</h4>
        <div class="code-block">
          <span class="cm">$ </span>git clone https://github.com/yourusername/Query-Management-System.git<br>
          <span class="cm">$ </span>cd Query-Management-System
        </div>
      </div>
    </div>
    <div class="step">
      <div class="step-num sn-2">2</div>
      <div class="step-content">
        <h4>Configure PostgreSQL</h4>
        <p>Update your connection string in <code>appsettings.json</code></p>
        <div class="code-block">
          <span class="ck">"pgconn"</span>: <span class="cv">"Host=localhost;Port=5432;Database=QueryManagementDB;Username=...;Password=..."</span>
        </div>
      </div>
    </div>
    <div class="step">
      <div class="step-num sn-3">3</div>
      <div class="step-content">
        <h4>Restore &amp; Run</h4>
        <div class="code-block">
          <span class="cm">$ </span>cd MVC<br>
          <span class="cm">$ </span>dotnet restore<br>
          <span class="cm">$ </span>dotnet run
        </div>
      </div>
    </div>
    <div class="step">
      <div class="step-num sn-4">4</div>
      <div class="step-content">
        <h4>Open in Browser</h4>
        <p>Visit <strong style="color:#a5f3fc;">https://localhost:5001</strong> to see your app running!</p>
      </div>
    </div>
  </div>

  <!-- PROJECT STRUCTURE -->
  <div class="section-title"><span class="dot dot-pink"></span>Project Structure</div>
  <div class="tree">
    <span class="folder">Query_Management_System/</span><br>
    ├── <span class="folder">📂 MVC/</span><br>
    │   ├── <span class="folder">📂 Controllers/</span><br>
    │   │   ├── <span class="file">AccountController.cs</span>   <span class="comment">← Login / Logout</span><br>
    │   │   ├── <span class="file">AdminController.cs</span>     <span class="comment">← Dashboard & user mgmt</span><br>
    │   │   ├── <span class="file">EmployeeController.cs</span>  <span class="comment">← Resolution & metrics</span><br>
    │   │   ├── <span class="file">QueryController.cs</span>     <span class="comment">← User query CRUD</span><br>
    │   │   └── <span class="file">UserController.cs</span>      <span class="comment">← Registration</span><br>
    │   ├── <span class="folder">📂 Views/</span>  <span class="comment">← Razor pages per role</span><br>
    │   ├── <span class="file">Program.cs</span>                 <span class="comment">← Entry point & DI config</span><br>
    │   └── <span class="file">MVC.csproj</span><br>
    └── <span class="folder">📂 Repository/</span><br>
    &nbsp;&nbsp;&nbsp;&nbsp;├── <span class="folder">Interfaces/</span>   <span class="comment">← IAdminInterface, IQueryInterface...</span><br>
    &nbsp;&nbsp;&nbsp;&nbsp;├── <span class="folder">Implementations/</span><span class="comment">← AdminRepository, QueryRepository...</span><br>
    &nbsp;&nbsp;&nbsp;&nbsp;└── <span class="folder">Models/</span>       <span class="comment">← t_Query, t_Registration...</span>
  </div>

  <!-- API ENDPOINTS -->
  <div class="section-title"><span class="dot dot-purple"></span>API Endpoints</div>

  <div class="ep-group">
    <div class="ep-label ep-auth">🔐 Account</div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Account/Login</span><span class="ep-desc">Show login page</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Account/Login</span><span class="ep-desc">Authenticate user</span></div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Account/Logout</span><span class="ep-desc">Clear session</span></div>
  </div>

  <div class="ep-group">
    <div class="ep-label ep-admin">🛡️ Admin</div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Admin/GetDashboardData</span><span class="ep-desc">All analytics</span></div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Admin/GetAllQuery</span><span class="ep-desc">List all queries</span></div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Admin/GetAllUsersData</span><span class="ep-desc">Fetch all users</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Admin/DeleteUser</span><span class="ep-desc">Remove a user</span></div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Admin/Delete?id=</span><span class="ep-desc">Delete a query</span></div>
  </div>

  <div class="ep-group">
    <div class="ep-label ep-emp">👷 Employee</div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Employee/GetUnsolvedQueries</span><span class="ep-desc">Open queries</span></div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Employee/GetPersonalMetrics</span><span class="ep-desc">Personal stats</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Employee/UpdateQueryStatus</span><span class="ep-desc">Resolve a query</span></div>
  </div>

  <div class="ep-group">
    <div class="ep-label ep-query">📝 Query</div>
    <div class="ep-row"><span class="method m-get">GET</span><span class="ep-path">/Query/GetUserQueries</span><span class="ep-desc">Own queries</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Query/CreateQuery</span><span class="ep-desc">Submit new query</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Query/UpdateQuery</span><span class="ep-desc">Edit a query</span></div>
    <div class="ep-row"><span class="method m-post">POST</span><span class="ep-path">/Query/DeleteQuery</span><span class="ep-desc">Remove a query</span></div>
  </div>

  <!-- CONTRIBUTING -->
  <div class="section-title"><span class="dot dot-teal"></span>Contributing</div>
  <div class="steps">
    <div class="step">
      <div class="step-num" style="background:#6366f1;">🍴</div>
      <div class="step-content"><h4>Fork the repository</h4><p>Click the Fork button on GitHub to create your own copy.</p></div>
    </div>
    <div class="step">
      <div class="step-num" style="background:#0ea5e9;">🌿</div>
      <div class="step-content">
        <h4>Create your branch</h4>
        <div class="code-block"><span class="cm">$ </span>git checkout -b feature/YourFeature</div>
      </div>
    </div>
    <div class="step">
      <div class="step-num" style="background:#10b981;">💾</div>
      <div class="step-content">
        <h4>Commit & Push</h4>
        <div class="code-block">
          <span class="cm">$ </span>git commit -m "Add YourFeature"<br>
          <span class="cm">$ </span>git push origin feature/YourFeature
        </div>
      </div>
    </div>
    <div class="step">
      <div class="step-num" style="background:#f59e0b;">🔁</div>
      <div class="step-content"><h4>Open a Pull Request</h4><p>Go to GitHub and open a PR against the main branch.</p></div>
    </div>
  </div>

  <!-- FOOTER -->
  <div class="footer">
    <p>Built with ❤️ using <strong>ASP.NET Core</strong> &amp; <strong>PostgreSQL</strong><br>
    MVC Pattern · Repository Layer · Session Auth · Role-Based Access</p>
    <a class="star-btn" href="#">⭐ Star this project</a>
  </div>

</div>
</body>
</html>
