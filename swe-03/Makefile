SUBDIR	=	aufgabe1

.PHONY: all clean ${SUBDIR} ${SUBDIR:=-clean}
all: ${SUBDIR}

${SUBDIR}:
	${MAKE} -C ${@} all

clean: ${SUBDIR:=-clean}

${SUBDIR:=-clean}:
	${MAKE} -C ${@:-clean=} clean
