#include <SDL.h>
#include "SDL_opengl.h"
#include "SDL_ttf.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char* args[]){

    SDL_Init(SDL_INIT_EVERYTHING);


    // memória
    SDL_GL_SetAttribute(SDL_GL_RED_SIZE, 8);
    SDL_GL_SetAttribute(SDL_GL_GREEN_SIZE, 8);
    SDL_GL_SetAttribute(SDL_GL_BLUE_SIZE, 8);
    SDL_GL_SetAttribute(SDL_GL_ALPHA_SIZE, 8);
    SDL_GL_SetAttribute(SDL_GL_BUFFER_SIZE, 32);
    SDL_GL_SetAttribute(SDL_GL_DEPTH_SIZE, 16);
    SDL_GL_SetAttribute(SDL_GL_DOUBLEBUFFER, 1);

    // nome da janela e icone
    SDL_WM_SetCaption("Meu Primeiro JOGO SDL", NULL);

    // tamanho da tela
    SDL_SetVideoMode(600,400,32, SDL_OPENGL);

    // cor da tela
    glClearColor(0.2,0.6,1,1);

    // área de exibição
    glViewport(0,0,600,400);

    // sombra da janela
    glShadeModel(GL_SMOOTH);

    // 2D
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity(); // desenhos geométricos

    // 3D desabilitado
    glDisable(GL_DEPTH_TEST);

    bool executando = true;
    SDL_Event eventos;

    // personagem

    float personL = 70;
    float personA = 5;
    float personX = 300 - (personL/2);
    float personY = 350;

    // inimigo
    float inimigoX = rand()%550;
    float inimigoY = 10;
    float inimigoL = 10;
    float inimigoA = 10;

    float velX = 2, velY = 2;

    bool esq = false, dir = false, cima = false, baixo = false;
    bool vitoria = true;


    // loop do jogo
    while(executando){
        //eventos
        while(SDL_PollEvent(&eventos)){

            // fechar janela com o botão X da janela
            if(eventos.type == SDL_QUIT){
                executando = !executando;
            }
            // fechar janela com a tecla ESC
            if((eventos.type == SDL_KEYUP)&&(eventos.key.keysym.sym == SDLK_ESCAPE)){
                executando = !executando;
            }

            // movimento quadrado
            if(eventos.type == SDL_KEYDOWN){
                if(eventos.key.keysym.sym == SDLK_LEFT){
                    esq = true;
                }
                else if(eventos.key.keysym.sym == SDLK_RIGHT){
                    dir = true;
                }
                else if(eventos.key.keysym.sym == SDLK_UP){
                    cima = true;
                }
                else if(eventos.key.keysym.sym == SDLK_DOWN){
                    baixo = true;
                }
            }

            else if(eventos.type == SDL_KEYUP){
                if(eventos.key.keysym.sym == SDLK_LEFT){
                    esq = !esq;
                }
                else if(eventos.key.keysym.sym == SDLK_RIGHT){
                    dir = !dir;
                }
                else if(eventos.key.keysym.sym == SDLK_UP){
                    cima = !cima;
                }
                else if(eventos.key.keysym.sym == SDLK_DOWN){
                    baixo = !baixo;
                }

            }
            if(!vitoria||velY==0){
                if(eventos.type == SDL_KEYDOWN){
                    if(eventos.key.keysym.sym == SDLK_RETURN){
                        vitoria = !vitoria;
                        inimigoX = rand()%550;
                        inimigoY = 10;
                        personX = 300 - (personL/2);
                        personY = 350;
                        velX = rand()%5;
                        while(velX == 0){
                            velX = rand()%5;
                        }
                        velY = rand()%5;
                        while(velY == 0){
                            velY = rand()%5;
                        }
                    }
                }
            }
        }

        // lógica

        // movimentação personagem
        if(esq){
            if (personX > 0){personX -= 8;}
            else {personX = 600-personL;}
        }
        else if(dir){
            if ((personX+personL) < 600){personX += 8;}
            else {personX = 0;}
        }
        else if(cima){
            if (personY > personA){personY -= 8;}
            else {personY = 400;}
        }
        else if(baixo){
            if (personY < 400){personY += 8;}
            else {personY = personA;}
        }

        // movimentação inimigo
        inimigoX += velX;
        inimigoY += velY;

        if(inimigoX < 0){
            velX = -velX;
        }
        else if((inimigoX+inimigoL) > 600){
            velX = -velX;
        }
        else if(inimigoY-inimigoA < 0){
            velY = -velY;
        }
        else if(inimigoY > 400){
            velY = -velY;
        }

        if(inimigoY >= personY-personA){
            if((inimigoX >= personX)&&(inimigoX <= (personX+personL))){
                velY = -velY;
                if((velX > 0)&&(inimigoX <= personX+(personL/2))){
                    velX = -velX;
                }
                else if((velX < 0)&&(inimigoX > personX+(personL/2))){
                    velX = -velX;
                }
            }
            else{
                velX = velY = 0;
                vitoria = !vitoria;
            }
        }


        // renderização
        glClear(GL_COLOR_BUFFER_BIT); // limpa o buffer

        // icnicia matriz
        glPushMatrix();

        // dimensões da matriz
        glOrtho(0,600,400,0,-1,1);

        // define cor do desenho
        //glColor3D(1 ou 0);
        //glColor3f(decimais);
        //glColor3ub(R,G,B); 0 - 255
        //glColor4ub(R,G,B,A); 0 - 255

        glColor4ub(80,150,200,255);

        // inicia desenho
        /*
        glBegin(GL_LINES); // GL_POINTS GL_LINES GL_LINES_LOOP GL_QUADS GL_TRIANGLES GL_POLIGON

        glVertex2f(60,60);  // primeiro ponto da linha 1
        glVertex2f(550,350);// segundo ponto da linha 1
        glVertex2f(60,350); // primeiro ponto da linha 2
        glVertex2f(550,60); // segundo ponto da linha 2
        glVertex2f(60,60); // primeiro ponto da linha 3
        glVertex2f(550,60); // segundo ponto da linha 3
        glVertex2f(60,350); // primeiro ponto da linha 4
        glVertex2f(550,350); // segundo ponto da linha 4
        glVertex2f(60,60); // primeiro ponto da linha 5
        glVertex2f(60,350); // segundo ponto da linha 5
        glVertex2f(550,60); // primeiro ponto da linha 6
        glVertex2f(550,350); // segundo ponto da linha 6

        glVertex2f(10,10); // primeiro ponto da letra A1
        glVertex2f(10,50); // segundo ponto da letra A1
        glVertex2f(10,10); // primeiro ponto da letra A2
        glVertex2f(40,10); // segundo ponto da letra A2
        glVertex2f(40,10); // primeiro ponto da letra A3
        glVertex2f(40,50); // segundo ponto da letra A3
        glVertex2f(10,30); // primeiro ponto da letra A4
        glVertex2f(40,30); // segundo ponto da letra A4

        glVertex2f(50,10); // primeiro ponto da letra D1
        glVertex2f(50,50); // segundo ponto da letra D1
        glVertex2f(50,10); // primeiro ponto da letra D2
        glVertex2f(90,10); // segundo ponto da letra D2
        glVertex2f(90,10); // primeiro ponto da letra D3
        glVertex2f(90,50); // segundo ponto da letra D3
        glVertex2f(90,50); // primeiro ponto da letra D4
        glVertex2f(50,50); // segundo ponto da letra D4

        glVertex2f(100,10); // primeiro ponto da letra R1
        glVertex2f(100,50); // segundo ponto da letra R1
        glVertex2f(100,10); // primeiro ponto da letra R2
        glVertex2f(130,10); // segundo ponto da letra R2
        glVertex2f(130,10); // primeiro ponto da letra R3
        glVertex2f(130,30); // segundo ponto da letra R3
        glVertex2f(130,30); // primeiro ponto da letra R4
        glVertex2f(100,30); // segundo ponto da letra R4
        glVertex2f(100,30); // primeiro ponto da letra R5
        glVertex2f(130,50); // segundo ponto da letra R5

        glVertex2f(145,10); // primeiro ponto da letra I1
        glVertex2f(145,50); // segundo ponto da letra I1
        glVertex2f(140,10); // primeiro ponto da letra I2
        glVertex2f(150,10); // segundo ponto da letra I2
        glVertex2f(140,50); // primeiro ponto da letra I3
        glVertex2f(150,50); // segundo ponto da letra I3

        glVertex2f(160,10); // primeiro ponto da letra E1
        glVertex2f(160,50); // segundo ponto da letra E1
        glVertex2f(160,10); // primeiro ponto da letra E2
        glVertex2f(190,10); // segundo ponto da letra E2
        glVertex2f(160,30); // primeiro ponto da letra E3
        glVertex2f(190,30); // segundo ponto da letra E3
        glVertex2f(160,50); // primeiro ponto da letra E4
        glVertex2f(190,50); // segundo ponto da letra E4

        glVertex2f(200,10); // primeiro ponto da letra L1
        glVertex2f(200,50); // segundo ponto da letra L1
        glVertex2f(200,50); // primeiro ponto da letra L2
        glVertex2f(230,50); // segundo ponto da letra L2

        // finaliza desenho
        glEnd();


        // Quadrado

        glBegin(GL_QUADS);

        glVertex2f(10,10);
        glVertex2f(590,10);
        glColor4ub(0,80,120,255); // Troca cor (Efeito Degrade)
        glVertex2f(590,390);
        glVertex2f(10,390);

        glEnd();

        */

        // desenha linha limite
        glColor4ub(70,85,100,255);
        glBegin(GL_LINES);

        glVertex2f(0,personY-personA);
        glVertex2f(600,personY-personA);

        glEnd();

        // desenha degrade embaixo
        glColor4ub(30,40,60,255);

        glBegin(GL_QUADS);

        glVertex2f(0,personY-personA);
        glVertex2f(600,personY-personA);

        glColor4ub(0,0,0,0);
        glVertex2f(600,400);
        glVertex2f(0,400);

        glEnd();

        glColor4ub(100,170,255,255);
        // desenha personagem
        glBegin(GL_QUADS);

        glVertex2f(personX,personY-personA);
        glVertex2f(personX+personL,personY-personA);
        glVertex2f(personX+personL,personY);
        glVertex2f(personX,personY);

        glEnd();


        // desenha inimigo
        glColor4ub(255,70,70,255);

        glBegin(GL_QUADS);

        glVertex2f(inimigoX,inimigoY-inimigoA);
        glVertex2f(inimigoX+inimigoL,inimigoY-inimigoA);
        glVertex2f(inimigoX+inimigoL,inimigoY);
        glVertex2f(inimigoX,inimigoY);

        glEnd();

        // fecha matriz
        glPopMatrix();

        // animações
        SDL_GL_SwapBuffers();

    }


    // SDL_Delay(5000);  Faz o programa esperar 5 segundos

    glDisable(GL_BLEND);

    SDL_Quit();

    return 0;
}
