using System.ComponentModel;

namespace ApiControle.Model
{
	public class Enums
	{
		public enum statusLicitacao
		{
			[Description("Aberta")]
			Aberta = 1,

			[Description("Em Andamento")]
			Em_Andamento = 2,

			[Description("Fechada")]
			Fechada = 3
		}
	}
}
