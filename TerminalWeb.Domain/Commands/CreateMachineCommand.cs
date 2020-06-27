﻿using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;
using TerminalWeb.Domain.Commands.Contracts;

namespace TerminalWeb.Domain.Commands
{
    public sealed class CreateMachineCommand : Notifiable, ICommand
    {
        public CreateMachineCommand() { }

        public CreateMachineCommand(string name, string ipLocal, bool antivirusInstalled, bool firewallIsActive, List<(string name, long totalSize)> diskDrives)
        {
            Name = name;
            IpLocal = ipLocal;
            AntivirusInstalled = antivirusInstalled;
            FirewallIsActive = firewallIsActive;
            DiskDrives = diskDrives;
        }

        public string Name { get; set; }
        public string IpLocal { get; set; }
        public bool AntivirusInstalled { get; set; }
        public bool FirewallIsActive { get; set; }
        public string WindowsVersion { get; set; }
        public List<(string name, long totalSize)> DiskDrives { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract().Requires());
        }
    }
}
