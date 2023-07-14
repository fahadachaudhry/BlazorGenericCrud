# Blazor + .NET Core Web API

#### Generic Repository CRUD Scaffolding

---

### Build Frontend

cd .\BlazorWithScaffolding\
dotnet watch

---

### Build Backend

cd .\GenericWebApi\
dotnet watch

---

### Start Tailwind Transpilation

cd .\BlazorWithScaffolding\
npx tailwindcss -i .\Styles\app.css -o .\wwwroot\css\site.css --watch;
