using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public partial class Vitals : Panel
{
	private Label Health;
	private Label Armor;
	private Panel HealthBar;
	private Panel ArmorBar;

	public Vitals()
	{
		StyleSheet.Load( "/ui/SandboxHud.scss" );

		Panel hudBackground = Add.Panel( "hudBackground" );
		//Panel hudBackground = Add.Panel( "hudBackground" );

		Panel playerPreviewBackground = Add.Panel( "playerPreviewBackground" );

		Panel healthBarBackground = hudBackground.Add.Panel( "healthBarBackground" );
		Panel armorBarBackground = hudBackground.Add.Panel( "armorBarBackground" );
		HealthBar = healthBarBackground.Add.Panel( "healthBar" );
		ArmorBar = armorBarBackground.Add.Panel( "armorBar" );

		//Health = hudBackground.Add.Label( "0", "healthText" ); // Displays the players health as a number
		//Armor = hudBackground.Add.Label( "0", "armorText" ); // Displays the players armor as a number
	}

	public override void Tick()
	{
		base.Tick();

		var player = Local.Pawn;
		if ( player == null ) return;

		//Health.Text = $"{player.Health.CeilToInt()}"; // Converts the players health into an intiger
		//Armor.Text = $"{player.Health.CeilToInt()}"; //  Converts the players armor into an intiger

		HealthBar.Style.Dirty();
		HealthBar.Style.Width = Length.Percent( player.Health );
		ArmorBar.Style.Dirty();
		ArmorBar.Style.Width = Length.Percent( player.Health );
	}
}
