class Tournament
{
    public List<Battle> Battles { get; set; }

    public Tournament(List<Battle> battles)
    {
        Battles = battles;
    }

    public List<string> ConductTournament()
    {
        List<string> winners = new List<string>();
        foreach (var battle in Battles)
        {
            string winner = battle.ConductBattle();
            winners.Add(winner);
        }
        return winners;
    }
}

