using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Geometry Shape Drawer");
				Console.ResetColor();
				Console.WriteLine();

				Console.Write("Enter the size of the figure (positive integer): ");

				if (int.TryParse(Console.ReadLine(), out int size))
				{
					if (size > 0)
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Rectangle:");
						Console.WriteLine();

						for (int i = 0; i < size; i++)
						{
							for (int j = 0; j < size; j++)
							{
								Console.Write("* ");
							}
							Console.WriteLine();
						}
						Console.WriteLine();

						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Left triangle:");
						Console.WriteLine();

						for (int i = 1; i <= size; i++)
						{
							for (int j = 0; j < i; j++)
							{
								Console.Write("* ");
							}
							Console.WriteLine();
						}
						Console.WriteLine();

						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Inverted left triangle:");
						Console.WriteLine();

						for (int i = size; i >= 1; i--)
						{
							for (int j = 0; j < i; j++)
							{
								Console.Write("* ");
							}
							Console.WriteLine();
						}
						Console.WriteLine();

						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("Decreasing Triangle:");
						Console.WriteLine();

						for (int i = size; i >= 1; i--)
						{
							for (int k = size - i; k > 0; k--)
							{
								Console.Write("  ");
							}
							for (int j = 0; j < i; j++)
							{
								Console.Write("* ");
							}
							Console.WriteLine();
						}

						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("Increasing Triangle:");
						Console.WriteLine();

						for (int i = 1; i <= size; i++)
						{
							for (int k = size - i; k > 0; k--)
							{
								Console.Write("  ");
							}
							for (int j = 0; j < i; j++)
							{
								Console.Write("* ");
							}
							Console.WriteLine();
						}
						Console.WriteLine();

						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine("Rhomb:");
						Console.WriteLine();

						for (int i = 0; i < size; i++)
						{
							for (int j = 0; j < size - i - 1; j++)
							{
								Console.Write(" ");
							}

							Console.Write("/");

							for (int j = 0; j < 2 * i; j++)
							{
								Console.Write(" ");
							}

							Console.Write("\\");

							Console.WriteLine();
						}

						for (int i = size - 1; i >= 0; i--)
						{
							for (int j = 0; j < size - i - 1; j++)
							{
								Console.Write(" ");
							}

							Console.Write("\\");

							for (int j = 0; j < 2 * i; j++)
							{
								Console.Write(" ");
							}

							Console.Write("/");

							Console.WriteLine();
						}
						Console.ResetColor();

						break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Size must be a positive integer!!! Please try again!!!");
						Console.ResetColor();
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid input!!! Please enter a valid integer!!!");
					Console.ResetColor();
				}
			}
			Console.WriteLine();

			while (true)
			{
				Console.Write("Enter the size of the chessboard (positive integer): ");

				if (int.TryParse(Console.ReadLine(), out int blockSize))
				{
					if (blockSize > 0)
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.WriteLine("Chessboard Drawer:");
						Console.WriteLine();

						for (int i = 0; i < 5; i++)
						{
							for (int row = 0; row < blockSize; row++)
							{
								if (i % 2 == 0)
								{
									for (int k = 0; k < 4; k++)
									{
										for (int col = 0; col < blockSize; col++)
										{
											Console.Write("* ");
										}

										Console.Write("  ");
									}
								}
								else
								{
									for (int k = 0; k < 4; k++)
									{
										for (int col = 0; col < blockSize; col++)
										{
											Console.Write("  ");
										}

										Console.Write("  ");
									}
								}

								Console.WriteLine();
							}
						}
						break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Size must be a positive integer! Please try again!");
						Console.ResetColor();
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid input! Please enter a valid integer!");
					Console.ResetColor();
				}
			}

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Press any key to exit!");
			Console.ResetColor();
			Console.ReadKey();
			Console.Clear();
		}
    }
}
