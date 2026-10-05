# Modelo de datos propuesto

El modelo se plantea a partir de las necesidades funcionales identificadas. Las entidades podrán ajustarse durante el desarrollo cuando se definan los campos definitivos.

## Entidades principales

### Usuario
Representa las cuentas que tendrán acceso al sistema.

Campos iniciales propuestos:
- IdUsuario
- Nombre
- Correo
- Clave
- Rol

### Miembro
Representa a las personas registradas en el gimnasio.

Campos iniciales propuestos:
- IdMiembro
- Nombre
- Documento
- Telefono
- Correo
- Estado

### Pago
Registra los pagos realizados por los miembros.

Campos iniciales propuestos:
- IdPago
- IdMiembro
- Fecha
- Concepto
- Estado

### Horario
Representa los horarios y eventos disponibles.

Campos iniciales propuestos:
- IdHorario
- Actividad
- Fecha
- HoraInicio
- HoraFin
- Cupo

### Inscripcion
Relaciona miembros con horarios o actividades.

Campos iniciales propuestos:
- IdInscripcion
- IdMiembro
- IdHorario
- Fecha

### PlanNutricional
Guarda el plan nutricional asignado a un miembro.

Campos iniciales propuestos:
- IdPlan
- IdMiembro
- Descripcion
- FechaInicio
- FechaFin

### Rutina
Guarda la rutina de entrenamiento asignada a un miembro.

Campos iniciales propuestos:
- IdRutina
- IdMiembro
- Descripcion
- FechaInicio
- FechaFin

> El modelo es preliminar. No se afirma que estas tablas ya existan en SQL Server.
