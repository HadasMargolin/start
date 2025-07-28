# Solus.Microservice.Base.Full

This is a complete shared base library for microservices in the SOLUS architecture.
It includes:

- Generic ApiResponse<T>
- BaseController<T> with standard response handling
- IRepository<T> interface with GenericRepository<T> default implementation
- BaseService<T> with logging and exception wrapper
- Centralized ExceptionMiddleware
- Swagger setup extension method

Every microservice should reference this base project to ensure consistency.