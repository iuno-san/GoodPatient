# <a href="https://goodpatient.azurewebsites.net"><img width="30" height="30" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/icons/Logo.png" /></a> GoodPatient | medical software  
<img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_X.png" />

# 👨‍⚕️ About
GoodPatient is an innovative application created to support private doctors in the effective management of their practice. The application offers comprehensive tools that enable intuitive adding of patients, planning visits, generating settlements, as well as a modern calendar of visits that improves the standards of work organization.<br><br>

## 🔒 Security:
- The use of the *Identity* package ensures a secure login system and account management, guaranteeing the protection of user data.<br>

## 🏥 Patient Management:

  - Efficiently add and manage patient records with a user-friendly interface.Access detailed patient information, including medical history and contact details.<br>

## 📅 Modern Appointment Calendar:
  - Utilize the cutting-edge calendar for intuitive appointment scheduling.

## 💸 Revenue Tracking:
  - Track and analyze practice revenue through integrated statistics.

## 🌱 Clean Architecture:
- The application is developed based on clean architecture, indicating well-organized code that is easy to maintain.<br>

## ⭐️ SOLID Principles:
- The application adheres to *SOLID* principles, demonstrating a professional approach to programming, resulting in flexibility and ease of extending functionality.<br><br><br>

<!--# 🍃What I Learned 

- Effectively applied *ASP.NET Core MVC* technologies.
- Implemented a secure login system and account management.
- Designed a responsive user interface.
- Make modern dashboard
- Developed an application adhering to clean architecture principles and *SOLID* patterns.
- Deploy app on Azure platform<br><br><br>-->

# 🔥Application Structure
```
GoodPatient
|
|-- GoodPatient.Application
|   |-- ApplicationUser
|   |   |-- CurrentUser.cs
|   |   |-- UserContext.cs
|   |
|   |-- Extensions
|   |   |-- ServiceCollectionExtensions.cs
|   |
|   |-- Mappings
|   |   |-- GoodPatientMappingProfile.cs
|   |
|   |--GoodPatient
|   |  |--Commands
|   |  |  |--...
|   |  |--Queries
|   |  |  |--...
|   |
|   |--GoodPatientEarnings
|   |  |--Commands
|   |  |  |--...
|   |  |--Queries
|   |  |  |--...
|   | 
|   |--GoodPatientService
|   |  |--Commands
|   |  |  |--...
|   |  |--Queries
|   |  |  |--...
| 
|-- GoodPatient.Domain
|   |-- Entities
|   |   |-- GoodPatient.cs
|   |   |-- GoodPatientService.cs
|   |
|   |-- Interfaces
|       |-- IGoodPatientRepository.cs
|       |-- IGoodPatientServiceRepository.cs
|
|-- GoodPatient.Infrastructure
|   |-- Extensions
|   |   |-- ServiceCollectionExtension.cs
|   |
|   |-- Migrations
|   |   |-- ...
|   |
|   |-- Persistance
|   |   |-- GoodPatientDbContext.cs
|   |
|   |-- Repositories
|       |-- GoodPatientRepository.cs
|       |-- GoodPatientServiceRepository.cs
|   
|-- GoodPatient.MVC
|   |-- Controllers
|   |   |-- HomeController.cs
|   |   |-- BlogController.cs
|   |   |-- GoodPatientController.cs
|   |
|   |-- Models
|   |   |-- ErrorViewModel.cs
|   |   |-- Notification.cs
|   |
|   |-- Views
|   |   |-- Home
|   |   |   |-- ...
|   |   |
|   |   |-- Blog
|   |   |   |-- ...
|   |   |
|   |   |-- GoodPatient
|   |       |-- ...
|   |
|   |-- wwwroot
|       |-- ...
|
|-- appsettings.json
|-- Program.cs
|-- Tailwind.config.js
|--

```
<br><br>

# 🌁Gallery of GoodPatient
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Main.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Dashboard.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Calendar.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Login.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_AccountManage.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Blog.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Docs.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Earnings.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_PatientList.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_PlanSection.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_FAQ.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Create.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Edit.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Details.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Contact.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_Register.png" /></a>
<a href="https://goodpatient.azurewebsites.net/"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/GoodPatient/master/GoodPatient.MVC/wwwroot/img/preview/GoodPatient_ForgotPassword.png" /></a>

<br><br>

# 🤖Technologies used
## GoodPatient.MVC (Presentation Layer)
```
- Dependencies:
  - Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter v8.0.0
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore v8.0.0
  - Microsoft.AspNetCore.Identity.UI v8.0.0
  - Microsoft.EntityFrameworkCore v8.0.0
  - Microsoft.EntityFrameworkCore.SqlServer v8.0.0
  - Microsoft.EntityFrameworkCore.Tools v8.0.0
  - Microsoft.VisualStudio.Web.CodeGeneration.Design v8.0.0
- Project References:
  - GoodPatient.Application
  - GoodPatient.Infrastructure
```
### GoodPatient.Application (Application Layer)
```
- Dependencies:
  - AutoMapper v12.0.1
  - AutoMapper.Extensions.Microsoft.DependencyInjection v12.0.1
  - FluentValidation.AspNetCore v11.3.0
  - MediatR.Extensions.Microsoft.DependencyInjection v11.1.0
  - Microsoft.Extensions.DependencyInjection.Abstractions v8.0.0
- Project References:
  - GoodPatient.Domain
```

## GoodPatient.Domain (Domain Layer)
```
- Dependencies:
  - Microsoft.Extensions.Identity.Stores v8.0.0
```

## GoodPatient.Infrastructure (Infrastructure Layer)
```
- Dependencies:
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore v8.0.0
  - Microsoft.AspNetCore.Identity.UI v8.0.0
  - Microsoft.EntityFrameworkCore v8.0.0
  - Microsoft.EntityFrameworkCore.SqlServer v8.0.0
  - Microsoft.EntityFrameworkCore.Tools v8.0.0
- Project References:
  - GoodPatient.Application
```

<br><br>

## 🌻 Feedback

If you have any feedback, please reach out to us at ignacysan27@gmail.com<br><br>

