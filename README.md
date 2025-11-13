# PrimerParcial_Practica_DAS
Vamos a Cargar datos en XML trabajar con DataSet



Vamos a trabajar con este diagrama, Copiar en PlantUML para verlo mejor
|-----------------------------------------------------------------------------|
@startuml

skinparam classAttributeIconSize 0



' Clases Principales de Usuarios '

abstract class Usuario {

    - id: Integer

    - nombre: String

    - email: String

    + autenticar(): Boolean

}



class Administrador extends Usuario {

    + crearHabitacion(num: String, tipo: TipoHabitacion, precio: Decimal): Habitacion

    + modificarHabitacion(num: String): Boolean

    + eliminarHabitacion(num: String): Boolean

    + configurarServicio(nombre: String, precio: Decimal): ServicioAdicional

    + generarInformeOcupacion(fechaInicio: Date, fechaFin: Date): Informe

}



class Recepcionista extends Usuario {

    + realizarCheckIn(reserva: Reserva): Estancia

    + hacerReservaInmediata(tipo: TipoHabitacion, huesped: Huesped): Reserva

    + realizarCheckOut(estancia: Estancia): Pago

    + buscarReserva(id: Integer): Reserva

    + asignarHabitacion(reserva: Reserva, habitacion: Habitacion): Boolean

    + atenderSolicitud(solicitud: SolicitudServicio): Boolean

}



class Huesped extends Usuario {

    - telefono: String

    + buscarDisponibilidad(fechaLlegada: Date, fechaSalida: Date): List<TipoHabitacion>

    + realizarReserva(tipo: TipoHabitacion, fechas: Date[]): Reserva

    + solicitarServicio(servicio: ServicioAdicional, cantidad: Integer): SolicitudServicio

    + solicitarCheckOut(): Boolean

}



' Clases de Reservas y Estancias (Expertas en su propia gestión) '

class Reserva {

    - id: Integer

    - fechaLlegada: Date

    - fechaSalida: Date

    - estado: String {Pendiente, Confirmada, Cancelada}

    + confirmar(): Boolean

    + cancelar(): Boolean

    + verificarConflicto(nuevaFechaLlegada: Date, nuevaFechaSalida: Date): Boolean

}



class Estancia {

    - id: Integer

    - checkIn: DateTime

    - checkOut: DateTime

    - estado: String {Activa, Finalizada}

    + agregarCargo(descripcion: String, monto: Decimal): DetalleCargo

    + finalizar(pago: Pago): Boolean

    + calcularTotalCargos(): Decimal

}



' Clases de Habitaciones y Servicios (Expertas en sus datos) '

class Habitacion {

    - numero: String

    - precioBase: Decimal

    - capacidad: Integer

    - disponibilidad: Boolean

    + verificarDisponibilidad(fechaLlegada: Date, fechaSalida: Date): Boolean

    + marcarOcupada(): Boolean

    + marcarDisponible(): Boolean

}



class TipoHabitacion {

    - nombre: String

    - descripcion: String

    - caracteristicas: String

}



class ServicioAdicional {

    - id: Integer

    - nombre: String

    - precio: Decimal

    - horario: String

    - disponibilidad: Boolean

    + estaDisponibleAhora(): Boolean

}



class SolicitudServicio {

    - id: Integer

    - fechaHora: DateTime

    - cantidad: Integer

    - estado: String {Pendiente, En Progreso, Atendida}

    + cambiarEstado(nuevoEstado: String): Boolean

    + calcularCostoTotal(): Decimal

}



class DetalleCargo {

    - id: Integer

    - descripcion: String

    - monto: Decimal

}



class Pago {

    - id: Integer

    - montoTotal: Decimal

    - fechaPago: DateTime

    - metodo: String

    + procesarPago(): Boolean

}



' Relaciones '

Huesped "1" -- "0..*" Reserva : realiza

Estancia "1" -- "1" Huesped : para



TipoHabitacion "1" <--- "0..*" Habitacion : es_de



Habitacion "1" o-- "0..*" Reserva : incluye

Habitacion "1" o-- "0..1" Estancia : ocupa



Estancia "1" *-- "0..*" DetalleCargo : acumula



Pago "1" *-- "0..*" DetalleCargo : incluye



ServicioAdicional "1" -- "0..*" SolicitudServicio : se_solicita

SolicitudServicio "1" -- "1" Estancia : pertenece_a



Estancia "1" -- "0..1" Pago : asociada_a



' Restricción OCL '

note right of Reserva::estado

    **Restricción OCL:**

    context Reserva inv:

    self.estado = 'Confirmada' implies

    self.habitacion.verificarDisponibilidad(self.fechaLlegada, self.fechaSalida)

end note



@enduml



Investigar como construir robots en el simular, Construir ambientes, escenarios para ejecuitar robots ty luego como construir robots y ambientes de ejecicion de bots.  Como montar un servidor para ejecutar WEBOTS en la nube.

WEBOTS
