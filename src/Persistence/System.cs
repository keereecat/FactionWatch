using System;
using System.Collections.Generic;
using Commons.Json;

namespace FactionWatch.Persistence {
	public class System : IPersistable {
		private String _name;
		private Dictionary<String, (Double, FactionState)> _factions;

		public String Name {
			get => _name;
			private set => _name = value;
		}
		public Dictionary<String, (Double, Persistence.FactionState)> Factions {
			get => _factions;
			private set => _factions = value;
		}

		public System(String name, Dictionary<String, (Double, FactionState)> factions) {
			Name = name;
			Factions = factions;
		}

		public System(String json) {
			dynamic systeminfo = JsonMapper.Parse(json);
			Name = (String)systeminfo.message.StarSystem;
			Factions = new Dictionary<String, (Double, FactionState)>();
			foreach (dynamic faction in systeminfo.message.Factions) {
				Enum.TryParse(value: (String)faction.FactionState, result: out FactionState factionState);

				Factions.Add((String)faction.Name, ((Double)faction.Influence, factionState));
			}
		}
	}
}
