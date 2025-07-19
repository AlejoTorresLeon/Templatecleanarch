# Athenea

Proyecto .NET siguiendo la arquitectura Clean Architecture (Arquitectura Limpia).

## 📐 Estructura del Proyecto

```
Athenea/
│
├── src/                         # Código fuente del sistema
│   ├── Athenea.Api/            # Proyecto API (punto de entrada)
│   ├── Athenea.Application/    # Lógica de aplicación (casos de uso)
│   ├── Athenea.Domain/         # Entidades del dominio y contratos
│   ├── Athenea.Infrastructure/ # Implementaciones de infraestructura
│   └── Athenea.Shared/         # Recursos compartidos (constantes, excepciones, etc.)
│
├── tests/                      # Pruebas unitarias y de integración
│   ├── Athenea.UnitTests/
│   └── Athenea.IntegrationTests/
│
├── .github/                    # Workflows de GitHub Actions (CI/CD)
│
├── .editorconfig               # Convenciones de estilo de código
├── .gitignore                  # Archivos y carpetas ignoradas por Git
├── README.md                   # Este archivo
└── Athenea.sln                 # Solución principal de Visual Studio
```

## 🧱 Principios de la Arquitectura Limpia

- Independencia de frameworks.
- Testabilidad.
- Independencia de UI.
- Independencia de base de datos.
- Independencia de cualquier agente externo.

## 🛠️ Tecnologías utilizadas

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- MediatR
- FluentValidation
- AutoMapper
- xUnit / Moq

## 🚀 Cómo ejecutar

```bash
dotnet restore
dotnet build
dotnet run --project src/MyProject.Api
```

## 🧪 Ejecutar pruebas

```bash
dotnet test
```

## 📄 Licencia

Este proyecto está licenciado bajo la licencia GPLv3.