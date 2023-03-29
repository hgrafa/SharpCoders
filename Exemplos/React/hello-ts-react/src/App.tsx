import { Header } from "./components/Header"
import {Post} from "./components/Post"
import { Magnet } from "@phosphor-icons/react";

import "./global.css";

const posts = [
  {
    "id": 1,
    "time": "2023-03-22 20:00",
    "imageUrl": "github.com/chandelima.png",
    "author": {
      "name": "Alexandre",
      "username" : "chandelima",
      "about": "Flamenguista"
    },
    "contents": [
      {"type":"title", "message":"Olá, cheguei!"},
      {"type":"paragraph", "message": "Olá meu primeiro tweet"},
      {"type":"paragraph", "message": "Acabei de chegar por aqui"},
      {"type":"link", "link":"#typescript"}
    ]
  },
  {
    "id": 2,
    "time": "2023-03-22 20:00",
    "imageUrl": "github.com/hgrafa.png",
    "author" : {
      "name": "Hugo",
      "username": "hgrafa",
      "about": "Flamenguista"
    },
    "contents": [
      {"type":"paragraph", "message": "Olá meu primeiro tweet"},
      {"type":"paragraph", "message": "Acabei de chegar por aqui"},
      {"type":"image", "imageLink":"https:www.github.com/hgrafa.png", "alternativeText": "Foto de perfil"},
      {"type":"image", "link":"https:www.github.com/hgrafa", "displayedText": "acesse meu github 🐈‍⬛"},
    ]
  }
]

export function App() {
  return (
    <div>
      <Header />
      {posts.map(post => {
        const obj = JSON.parse(JSON.stringify(post));
        const {id, author, contents, time} = obj;
        console.log(obj);
        return (
          <Post 
            key={id}
            author={author}
            contents={contents}
            time={time}
          />
        )
      })}
    </div>
  )
}