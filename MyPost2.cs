Post p1 = new Post("Post 1", "Desc 1");
p1.Publish();
p1.Like();
p1.Like();
p1.Like();
p1.Comment("Goуd");

Post p2 = new Post("Post2", "Desc 2");
p2.Like();
p2.Like();

Post p3 = new Post("Post3", "Desc 3");
p3.Like();

Post p4 = new Post("Post 4", "Desc 4");
p4.Like();
p4.Like();
p4.Like();
p4.Like();

Post p5 = new Post("Post5", "Desc5");

Post[] posts = { p1, p2, p3, p4, p5 };

for (int i = 0; i < posts.Length; i++)
{
    System.Console.WriteLine($"{posts[i].Title} – {posts[i].Description} – numbe of Like: {posts[i].LikeCount}");
}