using System.Reflection.PortableExecutable;
using LudvigMaskinParkBlazor.Services;
using LudvigMaskinParkBlazor.Shared;
using Machine = LudvigMaskinParkBlazor.Shared.Machine;

namespace LudvigMaskinParkBlazor.Components.Pages
{
    public partial class Machines
    {

        public List<Machine> MachineList { get; set; } = default!;

        protected override void OnInitialized()
        {

            MachineList = MockDataService.Machines;


            //MachineList = new List<Machine>
            //{
            //    new Machine { MachineId = Guid.NewGuid(), Name = "Machine 1" , Status = false},
            //    new Machine { MachineId = Guid.NewGuid(), Name = "Machine 2" , Status = true},
            //    new Machine { MachineId = Guid.NewGuid(), Name = "Machine 3" , Status = false},
            //    new Machine { MachineId = Guid.NewGuid(), Name = "Machine 4" , Status = true},
            //    new Machine { MachineId = Guid.NewGuid(), Name = "Machine 5" , Status = true}
            //};
        }
    }
}