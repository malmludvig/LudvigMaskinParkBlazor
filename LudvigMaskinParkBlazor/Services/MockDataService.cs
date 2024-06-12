using LudvigMaskinParkBlazor.Shared;
using System.Reflection;

namespace LudvigMaskinParkBlazor.Services

{
    public class MockDataService
    {
        private static List<Machine>? _machines = default!;

        public static List<Machine>? Machines
        {
            get
            {
                _machines ??= InitializeMockMachines();

                return _machines;
            }
        }


        private static List<Machine> InitializeMockMachines()
        {
            var machine1 = new Machine
            {
                MachineId = Guid.NewGuid(),
                Name = "Machine 1",
                Status = false

            };

            var machine2 = new Machine
            {
                MachineId = Guid.NewGuid(),
                Name = "Machine 2",
                Status = true

            };

            return [machine1, machine2];
        }
    }
}
