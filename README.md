# 🎭 Showtime – Festival Management Web App

Showtime is a full-stack Blazor web application designed to streamline festival planning, artist management, and booking processes.
Developed during my .NET Internship at NetRom Software (Jun–Jul 2025), the project focuses on usability, role-based control, and efficient scheduling for both organizers and users.

# 🚀 Features
### 👑 Admin Capabilities
-  🎟️ Festival Management – create, edit, and delete festivals with custom lineups and detailed information.

-  🎤 Lineup Builder & Band Scheduling – assign bands from the database to festivals, only if their events don’t overlap with others.

-  🎸 Band Management – add, edit, or remove bands (with name, genre, and members).
  
-  💾 SQL Server Integration – relational data storage using Entity Framework Core, ensuring consistency and scalability.

-  🎨 Modern UI – responsive interface built with Blazorise and reusable components.

-  🧩 OOP & Layered Architecture – clear separation between data, business logic, and presentation layers for maintainability.

### 👥 User Capabilities

-  🔍 Browse Festivals – explore available festivals, view lineups, and discover participating bands.

-  🎟️ Bookings Page – create or view personal bookings for festival attendance.

-  🧭 Read-Only Access – users can interact with data safely without editing permissions, ensuring a consistent admin-controlled environment.

## 🛠️ Tech Stack

| 💡 **Layer** | 🧩 **Technology** |
|---------------|------------------|
| **Frontend** | Blazor (Server-side), Blazorise |
| **Backend** | C#, ASP.NET Core (.NET 8) |
| **Database** | Microsoft SQL Server, Entity Framework Core |
| **Authentication** | ASP.NET Core Identity |
| **Architecture** | Layered Architecture (Models, Services, Data, UI) |
| **Tools** | Visual Studio 2022, SQL Server Management Studio, GitHub Desktop |

## 🧠 Key Learning Points

- Applied Object-Oriented Programming (OOP) and design principles to create modular, maintainable code.

- Improved database performance using LINQ queries and EF Core relationships.

- Collaborated using Git branching and code reviews, following clean code and commit best practices.

- Enhanced user experience with Blazor component reuse and event handling patterns.
  
- Gained valuable experience working alongside other interns — exchanging feedback, ideas, and best practices throughout development.

## ⚙️ Setup Instructions

Follow these steps to run the project locally:

1. **Clone the repository**
   ```bash
   git clone https://github.com/andra/Showtime.git
   cd Showtime
   ```
2. **Open the solution** : Open the .sln file in Visual Studio 2022.

3. **Configure the database connection** : In the appsettings.json file, update the connection string to match your local SQL Server setup.

4. **Apply Entity Framework migrations**
  ```bash
  Update-Database
```
5. **Run the application**
  ```bash
  dotnet run
```
6. **Access the web app** : Open your browser and navigate to 👉 https://localhost:5001


### 💡 Future Improvements

- AI-based artist recommendations for lineup optimization

- Integration with third-party event APIs (Spotify, Ticketmaster)
