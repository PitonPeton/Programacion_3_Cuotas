namespace Programacion_3_Cuotas.Models
{
	public static class CuotaViewModel
	{
		public static double Cuota(PrestamoViewModel value)
		{
			double result = 0;
			int interes = 0;

			switch (value.prestamo_tipo)
			{
				case "Personal":
					interes = 22;
					break;
				case "Auto":
					interes = 12;
					break;
				case "Hipotecario":
					interes = 8;
					break;
			}

			result = (value.prestamo_cantidad + value.prestamo_cantidad * interes / 100) / value.couta ;
			
			return result;
		}
	}
}
