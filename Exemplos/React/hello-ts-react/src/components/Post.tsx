import { useState } from "react";
import { Author } from "../model/Author";
import { Content as ContentModel } from "../model/Content";
import { Avatar } from "./Avatar";
import { Content } from "./Content";

import styles from "./Post.module.css";

interface PostProps {
  author: Author,
  contents: ContentModel[],
  time: Date
}

export function Post({author, contents, time } : PostProps) {

  const [likes, giveLike] = useState(0); // monitorada
  let gostei: number = 0;

  return (
    <div className={styles.post} >
      <header className={styles.header}>
        <div className={styles.author}>
          <Avatar username={author.username} />
          <div className={styles.authorInfo}>
            <strong>Autor: {author.name}</strong>
            <span>Sobre: {author.about}</span>
          </div>
        </div>

        <time title="27 de março de 2023 às 19:30" dateTime={time.toString()} >1 hour ago</time>
      </header>

      <Content contents={contents} />
      <button>responder</button>
      <button onClick={() => giveLike(likes+1)}></button>
      <button>repost</button>
    </div>
  )
}

// 1 - coisas que repetem
// 2 - separar lógica