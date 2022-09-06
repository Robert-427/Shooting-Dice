using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            SmackTalkingPlayer player1 = new SmackTalkingPlayer();
            player1.Name = "Bob";
            player1.Taunt = "Come on! Daddy needs a new pair of shoes";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            //player2.Play(player1);

            //Console.WriteLine("-------------------");

            HumanPlayer player3 = new HumanPlayer();
            player3.Name = "Wilma";

            //player3.Play(player2);

            //Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            //player1.Play(large);

            //Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer creative = new CreativeSmackTalkingPlayer();
            creative.Name = "Sir Tauntsalot";
            creative.SmackTalk = new List<string>() {
                "Come on, Big Numbers", "When you're hot, you're hot.", "No Whammy, no whammy"
            };

            SoreLoserPlayer loser = new SoreLoserPlayer();
            loser.Name = "Sir Whinesalot";

            UpperHalfPlayer upper = new UpperHalfPlayer();
            upper.Name = "Highroller";

            SoreLoserUpperHalfPlayer worst = new SoreLoserUpperHalfPlayer();
            worst.Name = "Sir Crybaby";

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, creative, upper, worst, loser
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}