
import styles from "./Avatar.module.css"

interface AvatarProps {
  username: string
  hasBorder?: boolean
}

export function Avatar({ username, hasBorder } : AvatarProps ) {
  hasBorder = false
  
  return (
    <img 
      className={ hasBorder ? styles.avatarWithBorder : styles.avatar }
      src={`https://github.com/${username}.png`}
    />
  )
}