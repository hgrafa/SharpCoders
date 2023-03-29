import { useState } from "react";
import styles from "./Post.module.css";
import { Content } from "./Content";

export function Post({author, contents, time}) {

  const [likes, giveLike] = useState(0);

  return (
    <div className={styles.post} >
      <div className={styles.author} >
        <div>
        <img src={author.image_url} ></img>
        <p>Autor: {author.name}</p>
        <p>Sobre: {author.about}</p>
        </div>
        <time dateTime={time} >1 hour ago</time>
      </div>
      <Content contents={contents} />
      <button>responder</button>
      <button onClick={() => giveLike(likes+1)} >gostei : {likes}</button>
      <button>repost</button>
    </div>
  )
}