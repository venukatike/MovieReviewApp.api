--------------------------------------------------------
	1. Install EF Core Packages
--------------------------------------------------------
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools


---------------------------------------------------------
	2. Add AutoMapper
---------------------------------------------------------
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

--------------------------------------------------------
✅ JWT Authentication Setup Plan
--------------------------------------------------------
1. Install Identity & JWT packages

2. Create User model (optional: extend IdentityUser)

3. Configure Identity & JWT in Startup.cs

4. Create AuthController (Register/Login)

5. Generate JWT token

Step 1: Install Required Packages
-------------------------------------------------------------------
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
-------------------------------------------------------------------

Step 2: Add Identity Models
Step 3: Update DbContext
Step 4: Configure Identity & JWT in Startup.cs
Step 5: Add JWT Config in appsettings.json
Step 6: Create AuthController