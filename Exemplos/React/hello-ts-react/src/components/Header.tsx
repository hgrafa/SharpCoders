import styles from "./Header.module.css";
import { Magnet } from "@phosphor-icons/react";

export function Header() {
  return (
    <div className={styles.header} >
      <Magnet className={styles.favicon} weight="fill" />
      Imã Bird
    </div>
  )
}