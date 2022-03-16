# ExamBlazorAuth
# ServerApp
nuget 설치
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Components.Authorization

# WebAssembly
## server 
nuget 설치 (5.0.13으로 통일)
Microsoft.AspNetCore.Authentication.JwtBearer

startup.cs
service jwtBearer 설치

LoginController.cs
코드 추가

appsettings.json 환경설정
``` json
  "JwtSecurityKey": "RANDOM_KEY_MUST_NOT_BE_SHARED",
  "JwtIssuer": "https://localhost",
  "JwtAudience": "https://localhost",
  "JwtExpiryInDays": 1
```

## shared
LoginModel, LoginResult 추가

## client
nuget 설치 (5.0.13으로 통일)
Blazored.LocalStorage
Microsoft.AspNetCore.Components.Authorization

Program.cs
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();

ApiAuthenticationStateProvider.cs
코드 추가

services 추가
AuthService.cs

razor 추가
Login, Logout

_imports.razor
``` csharp
@using WebAssemblyApp.Client.Services
@using WebAssemblyApp.Shared
@using Microsoft.AspNetCore.Components.Authorization
```

App.razor
<AuthorizeRouteView> 추가
<CascadingAuthenticationState> 추가