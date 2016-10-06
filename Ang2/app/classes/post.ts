import { Comment } from '../classes/comment';

export interface IPost {
  id: number;
  UserName: string;
  PublishDate: string;
  Image: string;
  Title: string;
  Text: string;
  Tags: string[];
  LikesCount: number;
  Comments: Comment[];
}

export class Post implements IPost {
   id: number;
   UserName: string;
   PublishDate: string;
   Image: string;
   Title: string;
   Text: string;
   Tags: string[];
   LikesCount: number;
   Comments: Comment[];

  constructor(title: string, text: string, user: string) {
      this.id = 0;
      this.PublishDate = "Saturday, June 13, 2015 11:19 PM";
      this.Image = "content/images/female-1.png";
      this.Tags = ["tag 1", "tag 2"];
      this.Title = title;
      this.Text = text;
      this.UserName = user;
      this.LikesCount = 12;
      this.Comments = [];
  }
}