using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
	public enum StatusTarefa
	{
		[Description("A Fazer")]
		AFazer = 1,
		[Description("Em andamento")]
		EmAndamento = 2,
		[Description("Conclu�do")]
		Concluido = 3,
	}
}