using LudvigMaskinParkBlazor.Services;
using LudvigMaskinParkBlazor.Shared;
using Microsoft.AspNetCore.Components;

namespace LudvigMaskinParkBlazor.Components.Pages
{
    public partial class MachineDetail
    {

        [Parameter]
        public Guid MachineId { get; set; }

        public Machine Machine { get; set; }

        protected override void OnInitialized()
        {

            //Vad gör koden
            //Den sätter propretien Machine för den här code behinden att bli samma Machine som finns lagrad med samma guid.
            //

            //Hämta data från lagrad Maskin, läs in den här

            //Stored

            //var CurrentMachine;

            //Foreach (var x in StoredMachines)
            /*
            {
            if(guid == StoredMachines.Machine.Guid)

            CurrentMachine == Stored

            }
            */
            //Machine = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);

            Machine = MockDataService.Machines.Single(e => e.MachineId == MachineId);

        }

    }
}
