using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShuffleUtil
{
    public static class ShuffleExtension
    {
        // Fisher-Yates shuffle
        public static void Shuffle<T>( this IList<T> iList )
        {
            if( iList == null )
                return;

            System.Random rand = new System.Random();

            for( int i = iList.Count - 1; i >= 0; i-- )
            {
                int randIndex = rand.Next( i + 1 );

                T itemR = iList[ randIndex ];
                iList[ randIndex ] = iList[ i ];
                iList[ i ] = itemR;
            }
        }
    }
}