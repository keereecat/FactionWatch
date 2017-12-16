using System;

namespace FactionWatch.Persistence {
	public enum FactionState : Byte {
		None,
		Boom,
		Bust,
		Outbreak,
		Lockdown,
		CivilUnrest,
		War,
		CivilWar,
		Election,
		Expansion,
		Retreat,
		Famine,
		Investment,
		Exiled
	}
}
