using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poker;

namespace Blackjack
{
    // 21 點分數計算
    public class BlackjackGameScore : PokerGameBase
    {
        private int cSpecialScore_BaseA = 1;
        private int cSpecialScore_ExtraA = 10;
        private int cSpecialScore_TJQK = 10;
        private int cMaxScore = 21;

        public override int GetScore( List<Card> iHandCards )
        {
            if( iHandCards == null )
                return 0;

            int aceCount = 0;
            int minimumScore = GetCardScore_Minimum( iHandCards, out aceCount );
            int extraScore = aceCount > 0 ? cSpecialScore_ExtraA : 0;

            if( ( minimumScore + extraScore ) <= cMaxScore )
                return minimumScore + extraScore;

            if( minimumScore <= cMaxScore )
                return minimumScore;

            return 0;
        }

        public int GetCardScore_Minimum( List<Card> iHandCards, out int iAceCount )
        {
            iAceCount = 0;
            int minimumScore = 0;
            
            if( iHandCards == null )
                return minimumScore;

            for( int i = 0; i < iHandCards.Count; i++ )
            {
                Card card = iHandCards[ i ];
                minimumScore += GetCardScore( card );

                if( card.CardInfo != null && card.CardInfo.Rank.Equals( (int)EPokerRank.Ace ) )
                    iAceCount++;
            }

            return minimumScore; 
        }

        public int GetCardScore( Card iCard )
        {
            if( iCard == null )
                return 0;

            if( iCard.CardInfo == null )
                return 0;

            switch( iCard.CardInfo.Rank )
            {
                case (int)EPokerRank.Number2:
                case (int)EPokerRank.Number3:
                case (int)EPokerRank.Number4:
                case (int)EPokerRank.Number5:
                case (int)EPokerRank.Number6:
                case (int)EPokerRank.Number7:
                case (int)EPokerRank.Number8:
                case (int)EPokerRank.Number9:
                    return iCard.CardInfo.Rank + 1;
                
                case (int)EPokerRank.Number10:
                case (int)EPokerRank.Jack:
                case (int)EPokerRank.Queen:
                case (int)EPokerRank.King:
                    return cSpecialScore_TJQK;

                case (int)EPokerRank.Ace:
                    return cSpecialScore_BaseA;

                default:
                    return 0;
            }
        }
    }
}