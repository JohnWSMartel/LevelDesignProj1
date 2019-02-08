using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathedMover : MonoBehaviour
{
    float moveSpeed = 3f;
    bool moveUp = false;
    bool moveDown = false;
    bool moveLeft = true;
    float dirX;
    float dirY;

    // Update is called once per frame
    void Update()
    {
        //rewriting variables every frame
        dirX = transform.position.x;
        dirY = transform.position.y;

        //hit left wall
        if(dirX < 2)
        {
            moveLeft = false;
        } else if (dirX > 37) //hit right wall
        {
            moveLeft = true;
        }        

        //Left/Right
        if (moveLeft)
        {
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);

            //First Spikeball
            //34-30 move down to -7
            if (dirX < 34 && dirX > 30)
            {
                if (dirY > -6)
                {
                    moveDown = true;
                }
                else
                {
                    moveDown = false;
                }
            }
            else if (dirX < 30 && dirX > 27) //come back up
            {
                if (dirY < -5)
                {
                    moveUp = true;
                }
                else
                {
                    moveUp = false;
                }
            }
            //2nd Ball seems fine
            //3rd Spikeball X = 13 - 8
            else if (dirX < 13 && dirX > 8) //move down
            {
                if (dirY > -6.5)
                {
                    moveDown = true;
                }
                else
                {
                    moveDown = false;
                }
            }
            else if (dirX < 9 && dirX > 2) //come up to final platform
            {
                if (dirY < -4.5f)
                {
                    moveUp = true;
                    Debug.Log(dirY);
                }
                else
                {
                    moveUp = false;
                }
            }
        } else //if moving right
        {
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);

            //3rd Spikeball
            if (dirX < 9 && dirX > 2) //come up to final platform
            {
                if (dirY > -6.5)
                {
                    moveDown = true;
                }
                else
                {
                    moveDown = false;
                }
            }
            //Move up to 2nd Spikeball
            else if (dirX < 13 && dirX > 8)
            {
                if (dirY < -5)
                {
                    moveUp = true;
                }
                else
                {
                    moveUp = false;
                }
            }
            //Move down to 1st Spikeball
            else if (dirX < 30 && dirX > 27)
            {
                if (dirY > -7)
                {
                    moveDown = true;
                }
                else
                {
                    moveDown = false;
                }
            }
            //move equal to starting platform
            else if(dirX < 34 && dirX > 30)
            {
                if(dirY < -5.7544)
                {
                    moveUp = true;
                } else
                {
                    moveUp = false;
                }
            }
        }

        //Up/Down/Level
        if (moveUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
        } else if (moveDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime, transform.position.z);
        }
    }
}
