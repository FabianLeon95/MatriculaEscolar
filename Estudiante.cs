﻿namespace MatriculaEscolar
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
    }
}
