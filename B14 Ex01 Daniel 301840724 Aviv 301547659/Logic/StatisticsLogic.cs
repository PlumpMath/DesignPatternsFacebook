namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;
    
    
    public class StatisticsLogic
    {
        private List<StatisticsUser> m_StatisticsUsersList;

        public StatisticsLogic(List<User> i_UsersList)
        {
            m_StatisticsUsersList = new List<StatisticsUser>();
            foreach (User user in i_UsersList)
            {
                m_StatisticsUsersList.Add(new StatisticsUser(user));

            }
        }

        public List<StatisticsUser> ComputeTopPhotosLikes()
        {
            FacebookObjectCollection<Album> UserAlbums = LoggedInFacebookUser.User.Albums;
            foreach (Album album in UserAlbums)
            {
                foreach (Photo photo in album.Photos)
                {
                    FacebookObjectCollection<User> PhotoLikeUsersList = photo.LikedBy;
                    foreach (StatisticsUser StatisticUser in m_StatisticsUsersList)
                    {
                        foreach (User LikedPhotoUser in PhotoLikeUsersList)
                        {
                            if (LikedPhotoUser.Id == StatisticUser.user.Id)
                            {
                                StatisticUser.PhotosLikesPressed = ++StatisticUser.PhotosLikesPressed;
                            }
                        }
                    }
                }
            }    
            sortStatisticsUsersListByLikes();
            return m_StatisticsUsersList;
        }
        
        public List<StatisticsUser> ComputeTopPostsLikes()
        {
            FacebookObjectCollection<Post> UserPosts = LoggedInFacebookUser.User.Posts;
            foreach (Post post in UserPosts)
            {
                FacebookObjectCollection<User> PostLikedByUsersList = post.LikedBy;
                foreach (StatisticsUser StatisticUser in m_StatisticsUsersList)
                {
                    foreach (User LikedPostUser in PostLikedByUsersList)
                    {
                        if (LikedPostUser.Id == StatisticUser.user.Id)
                        {
                            StatisticUser.PostsLikesPressed = ++StatisticUser.PostsLikesPressed;
                        }
                    }
                }
            }
            sortStatisticsUsersListByLikes();
            return m_StatisticsUsersList;
        }

        private void sortStatisticsUsersListByLikes()
        {
            m_StatisticsUsersList.Sort((user1, user2) =>
                {
                    if (user1.PhotosLikesPressed + user1.PostsLikesPressed > user2.PhotosLikesPressed
                        + user2.PostsLikesPressed)
                    {
                        return -1;
                    }

                    else
                    {
                        return 1;
                    }
                });
        }
    }
}
