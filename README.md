# MVC_PICA
Proyecto de Pica en .Net Core

# Implementación:
Implementación del Login por Identity de .Net Core.
Implementación de Autenticación y Autorización
Pagina de Errores Personalizada
Formulario de Contacto

# Uso:
La aplicación tiene 3 opciones, Inicio, Privacidad y Contacto, las opciones de Privaciodad y Contacto solo se puede hacer si esta logeado, en la aplicación se puede registrar y loguear (Componente Identity Individual).

El formulario de contactenos, solicita la información valida el tamaño del mensaje y que el correo sea correo, adicional los campos obligarorios son validados; para enviar la solicitud.

# Prerequisitos:
Tener Instalado .Net Core SDK 3.0

# Run:
Descarga/clona el repositorio y ejecuta el comando
```
dotnet run
```
URL WebApp:
```
https://localhost:5001/
```
# Api Rest
Se expone servicio Rest Post para Contactenos, con la siguiente URL:
```
https://localhost:5001/Api/contact
```
El servicio soporta Content Negotiation para JSON/XML
Ejemplo XML:
```xml
<?xml version="1.0" encoding="UTF-8"?>
<ContactModel>
   <Email>!email</Email>
   <FirstName>!nombre</FirstName>
   <LastName>!apellido</LastName>
   <Message>!mensaje</Message>
</ContactModel>
```
Ejemplo JSON:
```json
{
  "FirstName": "nombre",
  "LastName": "apellido",
  "Email": "email",
  "Message": "mensaje"
}
```
