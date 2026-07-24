import React, { Component } from "react";
import Post from "./Post";

class Posts extends Component {
  constructor(props) {
    super(props);

    this.state = {
      posts: [],
      error: null,
    };
  }

  // Fetch posts using Fetch API
  loadPosts = () => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((response) => {
        if (!response.ok) {
          throw new Error("Failed to fetch posts");
        }
        return response.json();
      })
      .then((data) => {
        const posts = data.map(
          (item) => new Post(item.id, item.title, item.body),
        );

        this.setState({
          posts: posts,
        });
      })
      .catch((error) => {
        this.setState({ error });
      });
  };

  // Lifecycle Hook
  componentDidMount() {
    this.loadPosts();
  }

  // Error Handling Lifecycle Hook
  componentDidCatch(error, info) {
    alert("An error occurred: " + error.message);
    console.log(info);
  }

  render() {
    if (this.state.error) {
      return <h2>{this.state.error.message}</h2>;
    }

    return (
      <div>
        <h1>Posts</h1>

        {this.state.posts.map((post) => (
          <div key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
            <hr />
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
