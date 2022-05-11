MCS	?=	mcs

PROG	?=	${SRCS:.cs=.exe}

.PHONY: all clean
all: ${PROG}

${PROG}: ${SRCS}
	${MCS} -langversion:7.1 -out:${PROG} ${SRCS}

clean:
	rm -f ${PROG}
