# Blazor + .NET Core Web API

#### Generic Repository CRUD Scaffolding

---

### Build Frontend

```
cd .\BlazorWithScaffolding\
```

```
dotnet watch
```

---

### Build Backend

```
cd .\GenericWebApi\
```

```
dotnet watch
```

---

### Start Tailwind Transpilation

```
cd .\BlazorWithScaffolding\
```

```
npx tailwindcss -i .\Styles\app.css -o .\wwwroot\css\site.css --watch;
```

### Adding a new xyz Table

1. Create xyz model for the table
2. Add DbSet<xyz> in AppDbContext
3. Create xyzRepo : GenericRepo
4. Register dependency

   ```
   services.AddScoped<xyzRepo>();
   ```
