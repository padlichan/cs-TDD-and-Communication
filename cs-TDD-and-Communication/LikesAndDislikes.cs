namespace cs_TDD_and_Communication
{
    
    public enum Reactions
    {
        LIKE,
        DISLIKE,
        NEUTRAL
    }
    
    public class LikesAndDislikes 
    {
        public static Reactions CalculateReaction(Reactions[] userReactions)
        {
            int likes = 0, dislikes = 0;
            foreach (Reactions reaction in userReactions)
            {
                if (reaction == Reactions.LIKE) likes++;
                if (reaction == Reactions.DISLIKE) dislikes++;
            }
            bool trueLike = likes % 2 != 0;
            bool trueDislike = dislikes % 2 != 0;
            if(trueLike && trueDislike) return Reactions.NEUTRAL;
            if(trueLike) return Reactions.LIKE;
            if (trueDislike) return Reactions.DISLIKE;
            return Reactions.NEUTRAL;
        }   
    }
}
