using System;
namespace Enigma
{
	public class EnigmaMachine
	{
        private readonly Rotor rotor;
        private readonly PlugBoard plugBoard;

        public EnigmaMachine(Rotor rotor, PlugBoard plugBoard)
		{
            this.rotor = rotor ?? throw new ArgumentNullException(nameof(rotor));
            this.plugBoard = plugBoard ?? throw new ArgumentNullException(nameof(plugBoard));
        }

        public string Encrypt(string text)
        {
            throw new NotImplementedException();
        }
	}
}

