using Godot;
using System;

public partial class NewScript : Node2D
{

	public override void _Ready()
	{
		int[,] matrix = new int[10, 10];

		// Fill the matrix with multiplication values
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				matrix[i, j] = (i + 1) * (j + 1);
			}
		}

		// Display the matrix as a multiplication table
		for (int i = 0; i < 10; i++)
		{
			string row = ""; // Initialize an empty string for the row
			for (int j = 0; j < 10; j++)
			{
				row += matrix[i, j].ToString().PadLeft(4); // Add each value to the row with spacing
			}
			GD.Print(row); // Output the row to the output panel
		}
	}
}
