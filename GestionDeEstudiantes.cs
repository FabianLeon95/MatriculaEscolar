namespace MatriculaEscolar
{
    public class GestionDeEstudiantes
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private List<Representante> representantes = new List<Representante>();
        private Dictionary<int, int> relacionEstudianteRepresentante = new Dictionary<int, int>();
        private int consecutivoEstudiantes = 1;
        private int consecutivoRepresentantes = 1;

        public void Ejecutar()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Listar estudiantes");
                Console.WriteLine("2. Agregar estudiante");
                Console.WriteLine("3. Editar estudiante");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ListarEstudiantes();
                        break;
                    case "2":
                        AgregarEstudiante();
                        break;
                    case "3":
                        EditarEstudiante();
                        break;
                    case "4":
                        EliminarEstudiante();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                        break;
                }
            }
        }

        private void ListarEstudiantes()
        {
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados");
                return;
            }

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"ID: {estudiante.Id}, Nombre: {estudiante.Nombre} {estudiante.Apellidos}");
            }
        }

        private void AgregarEstudiante()
        {
            Console.WriteLine("Datos del estudiante:");
            Console.Write("Nombre:");
            var nombre = Console.ReadLine();

            Console.Write("Apellidos:");
            var apellidos = Console.ReadLine();

            var estudiante = new Estudiante()
            {
                Id = consecutivoEstudiantes++,
                Nombre = nombre,
                Apellidos = apellidos
            };

            estudiantes.Add(estudiante);

            Console.WriteLine("Datos del representante:");
            Console.Write("Nombre:");
            nombre = Console.ReadLine();

            Console.Write("Apellidos:");
            apellidos = Console.ReadLine();
            var representante = new Representante
            {
                Id = consecutivoRepresentantes++,
                Nombre = nombre,
                Apellidos = apellidos
            };

            representantes.Add(representante);

            relacionEstudianteRepresentante.Add(estudiante.Id, representante.Id);
        }

        private void EditarEstudiante()
        {
            throw new NotImplementedException();
        }

        private void EliminarEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
