# Syllabus: Desarrollo Avanzado de Web APIs con .NET (Controller-Based)

**Perfil:** Mid–Senior Developer  
**Duración sugerida:** 8–10 semanas (enfoque práctico, arquitectura y runtime)

**Prerequisito recomendado:**  
Mini-Syllabus: *HTTP & HTTPS para Desarrolladores .NET*

---

## MÓDULO 1: Fundamentos Clave de C# y OOP (Refresher)

### 1.1 OOP moderno en C#
- Encapsulación, herencia, polimorfismo
- Interfaces vs clases abstractas
- Records, inmutabilidad

### 1.2 SOLID aplicado a APIs
- SRP en Controllers
- DIP y estabilidad de dependencias

🧪 **Laboratorio**  
Refactorizar lógica acoplada a un diseño orientado a interfaces y SOLID.

---

## MÓDULO 2: ASP.NET Core Internals & Hosting

### 2.1 Generic Host y lifecycle
- Program.cs
- Startup implícito

### 2.2 Middleware Pipeline
- Orden de ejecución
- Short-circuiting
- Middlewares custom

🧪 **Laboratorio**  
Implementar middleware de logging + correlación de requests.

---

## MÓDULO 3: Controllers, Routing y Contratos HTTP

### 3.1 Controllers profesionales
- `[ApiController]`
- Separación Controller vs Application

### 3.2 Routing avanzado
- Attribute routing
- Versioning por ruta y header

### 3.3 Action Results & Status Codes
- `ActionResult<T>`
- Diseño de contratos HTTP

🧪 **Laboratorio**  
CRUD versionado con respuestas REST correctas.

---

## MÓDULO 4: Model Binding, DTOs y Validaciones

### 4.1 Model Binding avanzado
- FromBody, FromRoute, FromQuery

### 4.2 Validaciones
- Data Annotations
- Validaciones custom
- ProblemDetails (RFC 7807)

🧪 **Laboratorio**  
Endpoints con validaciones complejas y errores estandarizados.

---

## MÓDULO 5: Filters, Attributes y Cross-Cutting Concerns

### 5.1 Filters
- Action, Exception, Result filters

### 5.2 Attributes custom
- Casos reales

🧪 **Laboratorio**  
Crear filtros reutilizables para logging, validación y manejo de errores.

---

## MÓDULO 6: Configuración y Options Pattern

### 6.1 Configuration providers
- appsettings
- Variables de entorno
- User secrets

### 6.2 Options Pattern
- IOptions / Snapshot / Monitor
- Validación de opciones

🧪 **Laboratorio**  
Configurar ambientes múltiples usando opciones fuertemente tipadas.

---

## MÓDULO 7: Dependency Injection, Clean Architecture y DDD

### 7.1 DI avanzado
- Lifetimes
- Anti-patterns

### 7.2 Clean Architecture
- API, Application, Domain, Infrastructure

### 7.3 DDD práctico
- Entities, Value Objects, Aggregates

### 7.4 Object Mapping
- Mapping manual
- AutoMapper con criterio

🧪 **Laboratorio**  
Reestructurar la solución a Clean Architecture con mapping explícito y AutoMapper.

---

## MÓDULO 8: Persistencia, Caching y Performance

### 8.1 EF Core avanzado
- Tracking vs NoTracking
- Projections

### 8.2 Caching
- Memory Cache
- Distributed Cache
- Redis
- Cache invalidation

🧪 **Laboratorio**  
Optimizar endpoints usando EF Core + caching distribuido.

---

## MÓDULO 9: Integraciones, Resiliencia y HTTP Clients

### 9.1 HttpClientFactory
- Typed clients

### 9.2 Resiliencia
- Retries
- Timeouts
- Circuit breakers (Polly)

🧪 **Laboratorio**  
Consumir una API externa de forma resiliente.

---

## MÓDULO 10: Seguridad, Rate Limiting y Protección de APIs

### 10.1 Autenticación y autorización
- JWT
- Policies y claims

### 10.2 Rate limiting
- Fixed / sliding window
- Policies

🧪 **Laboratorio**  
Proteger endpoints con JWT y rate limiting.

---

## MÓDULO 11: Observabilidad, Health Checks y Background Services

### 11.1 Observabilidad
- Logging estructurado
- Correlation IDs
- Tracing (conceptual)

### 11.2 Health Checks
- Liveness
- Readiness

### 11.3 Background Services
- IHostedService
- Worker patterns

🧪 **Laboratorio**  
Implementar health checks y un background service funcional.

---

## MÓDULO 12: Testing con xUnit

### 12.1 Unit testing
- xUnit
- AAA Pattern

### 12.2 Testing de Controllers y Services
- Moq

🧪 **Laboratorio**  
Suite de tests unitarios para Application y API layers.

---

## MÓDULO 13: Contenerización y Kubernetes

### 13.1 Docker
- Dockerfile multi-stage

### 13.2 Docker Compose
- Orquestación local

### 13.3 Kubernetes
- Deployments
- Services
- ConfigMaps y Secrets

🧪 **Laboratorio**  
Desplegar la API en Docker Compose y Kubernetes local.

---

## PROYECTO FINAL

Desarrollar una **Web API de nivel enterprise** que incluya:
- Clean Architecture + DDD
- EF Core + Caching
- Seguridad + Rate limiting
- Resiliencia
- Observabilidad
- Tests con xUnit
- Docker + Kubernetes

---

## RESULTADO ESPERADO

Al finalizar, el desarrollador será capaz de diseñar, operar y desplegar Web APIs modernas, escalables y mantenibles en entornos productivos reales.

