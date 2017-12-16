using System;
using System.Collections.Generic;

namespace FactionWatch.Persistence {
	public class Faction : IPersistable {
		private String _name;
		private Dictionary<String, ValueTuple<Single, FactionState>> _systems;

		public String Name { get => _name; protected set => _name = value; }
		public Dictionary<String, (Single, FactionState)> Systems { get => _systems; private set => _systems = value; }

		public Faction(String name, Dictionary<String, (Single, FactionState)> systems) {
			Name = name;
			Systems = systems;
		}
	}
}
