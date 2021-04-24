#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <SDL.h>
#define TICK_INTERVAL 30 /* intervalo de tempo do timer */
Uint32
deutempo(void)
{
    static Uint32 next_time = 0;
    Uint32 now;
    now = SDL_GetTicks();
    if (next_time <= now)
    {
        next_time = now + TICK_INTERVAL;
        return (0);
    }
    return (next_time - now);
}
main()
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        fprintf(stderr, "não foi possível inicializar SDL: %s\n", SDL_GetError());
        exit(1);
    }
    else
    {
        printf("OK SDL");
    }
    /*tamanho da tela*/
    int largura=400;
    int altura=300;
    SDL_Event event;
    SDL_keysym keysym;
    /********************/
    SDL_Surface *screen;
    screen = SDL_SetVideoMode(largura, altura, 32, SDL_SWSURFACE);
    if (screen == NULL)
    {
        fprintf(stderr, "Impossível ajustar ao vídeo em %ix%i : %s\n", largura,altura,SDL_GetError());
        exit(1);
    }
    int tempo = 0;
    int posicaoX, posicaoY;
    posicaoY = posicaoX = 60;
    int posicaoY_anterior = 60, posicaoX_anterior = 60, raio = 18;
    int velocidadeX = 30, velocidadeY = 30;

    {
        /*loop infinito, cuida da movimentação da bolinha */
        if (deutempo() == 0)
            while (1)
            {

                {
                    /* se for zero, entao ointervalo de tempo ja se completou */

                    /* ***************************************** **
                    * verifica se os limites da **
                    * tela ja foram alcaçados. **
                    * se foram, inverte a **
                    * velocidade x ou y **
                    * ***************************************** * */
                    if (posicaoY >= (altura - raio*2))
                        velocidadeY = velocidadeY * (-1);
                    if (posicaoX >= largura - raio)
                        velocidadeX = velocidadeX * (-1);
                    if (posicaoX < raio)
                        velocidadeX = velocidadeX * (-1);
                    if (posicaoY < raio*2)
                        velocidadeY = velocidadeY * (-1);

                    /* ***************************************** * */
                    bola(posicaoX_anterior, posicaoY_anterior, raio,screen, 0, 0, 0);
                    bola(posicaoX, posicaoY, raio, screen, 86051435, 256323, 56546);  //cor
                    posicaoX_anterior = posicaoX;
                    posicaoY_anterior = posicaoY;
                    posicaoX += velocidadeX;
                    posicaoY += velocidadeY;
                    SDL_UpdateRect(screen, 0, 0, 0, 0);
                    SDL_Event event;
                    while (SDL_PollEvent(&event))
                    {
                        switch (event.type)
                        {
                        case SDL_KEYDOWN:
                            break;
                        case SDL_KEYUP:
                            if (event.key.keysym.sym == SDLK_ESCAPE)
                                return 0;
                            break;
                        case SDL_QUIT:
                            return(0);

                        }

                    }
                }
            }
    }
    atexit(SDL_Quit);

}
bola(int x, int y, int r, SDL_Surface * screen, Uint8 R, Uint8 G, Uint8 B)
{
    int a,b;
    int vari;
    unsigned int cateto1, cateto2;

    for (a = x - r ; a <= x + r ; a++)
    {
        cateto1 = x - a;
        cateto2 = sqrt((r * r) - (cateto1 * cateto1));/*pitágoras*/
        int altu;
        for (altu = y - cateto2 ; altu <= y + cateto2 ; altu++)
            desenhaPonto(screen, R, G, B, a, altu);
    }

}
desenhaPonto(SDL_Surface * screen, Uint8 R, Uint8 G, Uint8 B, int x, int y)
/* desenha um ponto na tela de acordo com as coordenadas fornecidas */
{
    Uint32 color = SDL_MapRGB(screen->format, R, G, B);
    Uint32 *bufp;
    bufp = (Uint32 *) screen->pixels + y * screen->pitch/4 + x; // angulo
    *bufp=color;

}
