using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poker;

namespace Blackjack
{
    public class BlackjackGameScore : PokerGameBase
    {
        private int cMaxScore = 21;
        private Dictionary<int, int> mScoreDeck = new()
        {

        };

        public override int GetScore( List<Card> iHandCards )
        {
            int totalScore = 0;

            if( iHandCards == null )
                return totalScore;

            /*for( int i = 0; i < iHandCards.Count; i++ )
            {
                totalScore
            }*/

            return totalScore;
        }
    }
}