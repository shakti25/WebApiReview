# Mini-Syllabus: HTTP & HTTPS para Desarrolladores .NET (Mid–Senior)

**Duración sugerida:** 1–2 sesiones intensivas  
**Nivel:** Mid–Senior Backend Developer

**Objetivo:**  
Reforzar HTTP y HTTPS como **contrato, pipeline y base de diseño** para APIs profesionales en ASP.NET Core, alineado con arquitecturas modernas, escalabilidad, observabilidad y resiliencia.

---

## MÓDULO 1: HTTP como Contrato y Pipeline

### 1.1 Request lifecycle (visión práctica)
- Request / Response como flujo
- Statelessness real
- Short-circuiting

### 1.2 Métodos HTTP e idempotencia
- Safe vs idempotent
- Efecto en retries y background processing
- Errores comunes en APIs reales

### 1.3 HTTP y el pipeline backend
- Intercepción de requests
- Relación directa con middlewares y filters

🧪 **Laboratorio**  
Inspeccionar el lifecycle de una request HTTP real y su impacto en el pipeline.

---

## MÓDULO 2: Status Codes, Headers y Diseño de Contratos

### 2.1 Status codes como diseño
- 2xx, 3xx, 4xx, 5xx
- 400 vs 422, 401 vs 403, 409
- RFC 7807 – ProblemDetails

### 2.2 Headers como mecanismos
- Authorization
- Content-Type / Accept
- Cache-Control / ETag
- Versioning headers
- Correlation IDs

🧪 **Laboratorio**  
Diseñar contratos HTTP coherentes y predecibles para endpoints reales.

---

## MÓDULO 3: HTTP, Caching y Escalabilidad

### 3.1 Semántica de caching
- Cache-Control
- ETags
- When not to cache

### 3.2 Escalabilidad HTTP
- Por qué stateless escala
- Impacto en Redis y caching distribuido

🧪 **Laboratorio**  
Evaluar estrategias de caching HTTP y su impacto en performance.

---

## MÓDULO 4: HTTPS, Proxies y Runtime Real

### 4.1 HTTPS y TLS (visión práctica)
- TLS handshake (conceptual)
- Certificados
- HTTPS en dev vs prod

### 4.2 Reverse proxies y Kubernetes
- HTTPS termination
- Forwarded headers
- Ingress controllers

🧪 **Laboratorio**  
Analizar tráfico HTTPS bajo reverse proxy y entorno containerizado.

---

## MÓDULO 5: HTTP para Observabilidad y Resiliencia

### 5.1 Observabilidad basada en HTTP
- Correlation IDs
- Logging estructurado

### 5.2 HTTP y resiliencia
- Timeouts
- Retries
- Efecto en clientes HTTP

🧪 **Laboratorio**  
Trazar una request end-to-end considerando headers, errores y retries.

---

## RESULTADO ESPERADO

Al finalizar este mini-syllabus, el desarrollador será capaz de:
- Diseñar contratos HTTP correctos y escalables
- Entender el impacto real de HTTP en middlewares, filters y runtime
- Preparar APIs para caching, resiliencia y observabilidad
- Conectar fundamentos HTTP con arquitecturas backend modernas

---

**Este mini-syllabus es prerequisito directo para:**
- Syllabus: Desarrollo Avanzado de Web APIs con .NET (Controller-Based)
- Syllabus: ASP.NET Core MVC
