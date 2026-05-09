# Sistema de Revisión Vehicular

## Descripción

Proyecto académico desarrollado con .NET y Domain-Driven Design (DDD) para modelar el dominio de un sistema de revisión vehicular.

## Objetivo

Implementar la capa de dominio aplicando:

- Entidades
- Value Objects
- Eventos de dominio
- Servicios de dominio
- Arquitectura en capas

## Tecnologías

- C#
- .NET
- Git
- GitHub

## Entidades principales

### 1. Vehículo

#### Datos:
- Id
- Placa
- Marca
- Modelo
- Año
- PropietarioId

### 2. Propietario

#### Datos:
- Id
- Nombre
- Cédula
- Correo
- Teléfono

### 3. Revisión

#### Datos:
- Id
- VehiculoId
- FechaRevision
- EstadoRevision
- ResultadoGases
- ResultadoFrenos
- ResultadoLuces

### 4. Inspector

#### Datos:
- Id
- Nombre
- CodigoEmpleado

## Estados de revisión

- NoRevisado
- EsperandoRevision
- RevisionAprobada
- RevisionNoAprobada

## Flujo de negocio

```text
NoRevisado
      ↓
EsperandoRevision
      ↓
RevisionAprobada o RevisionNoAprobada

## Reglas de negocio

- Regla 1: No se puede aprobar una revisión si alguna prueba falla.
- Regla 2: No se puede revisar un vehículo no registrado.
- Regla 3: Una revisión aprobada no puede volver a “esperando”.
- Regla 4: No se puede realizar revisión sin inspector asignado.
- Regla 5: La placa debe tener formato válido.